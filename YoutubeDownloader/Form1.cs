using MediaToolkit;
using MediaToolkit.Model;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;
namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        public class FilePath
        {
            string file_name = "";
            public string NameOnly
            {
                get { return file_name; }
                set
                {
                    file_name = ReplaceInvalidChars(value);
                }
            }
            public string Extension { get; set; } = "";
            public string Folder { get; set; } = "";
            public string Name
            {
                get
                {
                    return NameOnly + "." + Extension;
                }
            }
            public string FullPath
            {
                get
                {
                    return Path.Combine(Folder, Name);
                }
            }
            public string FullPathWithoutExt {
                get
                {
                    return Path.Combine(Folder, NameOnly);
                }
            }
            static string ReplaceInvalidChars(string filename)
            {
                return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
            }

        }
        FilePath videoPath;
        public Form1()
        {
            InitializeComponent();
            videoPath = new();
            progressBar.Hide();
            resolution_group.Hide();

        }
        void progress(double value)
        {
            progressBar.Value = (int)(100 * value);
        }
        void progress_event(object? sender, ConvertProgressEventArgs e)
        {
            var percent = e.ProcessedDuration.TotalSeconds/e.TotalDuration.TotalSeconds;
            progress(percent);
        }
        void state(string text)
        {
            state_label.Text = text;
        }
        void ConvertToMP3()
        {
            var inputFile = new MediaFile(videoPath.FullPath);
            var outputFile = new MediaFile(videoPath.FullPathWithoutExt + ".mp3");
            using (var ffmpeg = new Engine())
            {
                ffmpeg.ConvertProgressEvent += progress_event;
                ffmpeg.ConversionCompleteEvent += (s, e) => { progress(1); };
                ffmpeg.Convert(inputFile, outputFile);
            }
        }
        int getResolution()
        {
            RadioButton checkedButton = resolution_group.Controls.
                OfType<RadioButton>().First(b => b.Checked);
            string text = checkedButton.Text.Replace("p", "");
            return int.Parse(text);
        }
        async void download(string ext)
        {
            try
            {
                state("Getting video info...");
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
                        .Where(s => s.VideoResolution.Height == getResolution()).First();
                }
                videoPath.NameOnly = videoInfo.Title;

                videoPath.Extension = streamInfo.Container.Name;

                videoPath.Folder = path_input.Text;
                switchShowProgressBar();
                state("Downloading...");
                await youtube.Videos.Streams.DownloadAsync(streamInfo,
                    videoPath.FullPath,
                    new Progress<double>(progress));
                state("mp4 file downloaded!");
                if (ext == "mp3")
                {
                    state("Converting ...");
                    var task = new Task(() => ConvertToMP3());
                    task.Start();
                    await task;
                    progress(1);
                    state("mp3 file downloaded!");
                    removeVideo();
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
            progressBar.BeginInvoke(() => {
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
            progress(0);
            start_button.Enabled = false;
            try
            {
                if (check_mp3.Checked)
                {
                    download("mp3");
                }
                else if (check_mp4.Checked)
                {
                    download("mp4");
                }
            }
            catch(Exception)
            {
                reset();
            }
            
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                path_input.Text = dialog.SelectedPath;
            }
        }

        private void paste_button_Click(object sender, EventArgs e)
        {
            link_input.Text = Clipboard.GetText();
        }

        void removeVideo()
        {
            File.Delete(videoPath.FullPath);
        }

        private void check_mp4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (check_mp4.Checked)
            {
                resolution_group.Show();
            }
            else
            {
                resolution_group.Hide();
            }
        }
    }
}