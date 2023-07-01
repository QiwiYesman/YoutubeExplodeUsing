using MediaToolkit;
using MediaToolkit.Model;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;
using PaintedControls;
namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {

        FilePath videoPath;
        CustomCheckBox LastResolution, LastFormat;
        public Form1()
        {
            InitializeComponent();
            videoPath = new();
            progressBar.Hide();
            resolution_group.Hide();
            check_mp3.Checked = true;
            LastFormat = check_mp3;
            check_720.Checked = true;
            LastResolution = check_720;
        }
        void Progress(double value) => progressBar.Percent = (int)(100 * value);
        void ProgressEvent(object? sender, ConvertProgressEventArgs e) =>
            Progress(e.ProcessedDuration.TotalSeconds / e.TotalDuration.TotalSeconds);
        void State(string text) => state_label.Text = text;
        void ConvertToMP3()
        {
            var inputFile = new MediaFile(videoPath.FullPath);
            var outputFile = new MediaFile(videoPath.FullPathWithoutExt + ".mp3");
            using var ffmpeg = new Engine();
            ffmpeg.ConvertProgressEvent += ProgressEvent;
            ffmpeg.ConversionCompleteEvent += (s, e) => { Progress(1); };
            ffmpeg.Convert(inputFile, outputFile);
        }
        int GetResolution() => int.Parse(LastResolution.Text.Replace("p", ""));

        async void Download(string ext)
        {
            try
            {
                State("Getting video info...");
                string link = link_input.Text;

                var youtube = new YoutubeClient();
                var videoInfo = await youtube.Videos.GetAsync(link);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(link);
                IStreamInfo streamInfo;
                if (ext == "mp3")
                {
                    streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                }
                else
                {
                    streamInfo = streamManifest.GetVideoStreams()
                        .Where(s => s.Container == YoutubeExplode.Videos.Streams.Container.Mp4)
                        .Where(s => s.VideoResolution.Height == GetResolution()).First();
                }
                videoPath.NameOnly = videoInfo.Title;

                videoPath.Extension = streamInfo.Container.Name;

                videoPath.Folder = path_input.Text;
                switchShowProgressBar();
                State("Downloading...");
                await youtube.Videos.Streams.DownloadAsync(streamInfo,
                    videoPath.FullPath,
                    new Progress<double>(Progress));
                State("mp4 file downloaded!");
                if (ext == "mp3")
                {
                    State("Converting ...");
                    Progress(0);
                    await Task.Run(() => ConvertToMP3());
                    Progress(1);
                    State("mp3 file downloaded!");
                    RemoveVideo();
                }
                start_button.Enabled = true;
                switchShowProgressBar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                reset();
                return;
            }
        }
        void switchShowProgressBar()
        {
            progressBar.BeginInvoke(() =>
            {
                if (progressBar.Visible)
                {
                    progressBar.Hide();
                }
                else
                {
                    progressBar.Show();
                }
            });
        }
        void reset()
        {
            progressBar.Hide();
            start_button.Enabled = true;
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            Progress(0);
            start_button.Enabled = false;
            try
            {
                if (check_mp3.Checked)
                {
                    Download("mp3");
                }
                else if (check_mp4.Checked)
                {
                    Download("mp4");
                }
            }
            catch (Exception)
            {
                reset();
            }

        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path_input.Text = dialog.SelectedPath;
            }
        }

        private void paste_button_Click(object sender, EventArgs e)
        {
            link_input.Text = Clipboard.GetText();
        }

        void RemoveVideo() => File.Delete(videoPath.FullPath);

        private void OnMPClick(object sender, EventArgs e)
        {
            var checkButton = (CustomCheckBox)sender;

            if (Equals(checkButton, LastFormat))
            {
                checkButton.Checked = true;
                return;
            }
            LastFormat = checkButton;
            var checks = new[] { check_mp3, check_mp4 };

            foreach (CustomCheckBox check in checks)
            {
                if (!Equals(checkButton, check))
                {
                    check.Checked = false;
                }
            }
            if (check_mp4.Checked)
            {
                resolution_group.Show();
            }
            else
            {
                resolution_group.Hide();
            }
        }

        private void OnResClick(object sender, EventArgs e)
        {
            var checkButton = (CustomCheckBox)sender;

            if (Equals(checkButton, LastResolution))
            {
                checkButton.Checked = true;
                return;
            }
            LastResolution = checkButton;
            var checks = new[] { check_720, check_480, check_360 };

            foreach (CustomCheckBox check in checks)
            {
                if (!Equals(checkButton, check))
                {
                    check.Checked = false;
                }
            }
        }
    }
}