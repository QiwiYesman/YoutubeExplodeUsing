# YoutubeExplodeUsing
Додаток для завантаження mp4 або mp3 файлів, розміщені на YouTube. Сам процес завантаження здійснюється за допомогою YoutubeExplode.
mp4 може бути завантажено у якості:
- 720p
- 480p
- 360p
  
При обранні mp3 спочатку завантажується файл webm або mp4, що містить лише аудіодоріжку, і потім конвертується в mp3, після чого видаляє завантажений mp4/webm.
Конвертація в mp3 здійснюється за допомогою ffmpeg, а точніше, його обгорткою MediaToolkit.
Гілка WithCustomControls використовує репозиторій WinformPaintedControls для оновлено зовнішнього вигляду. Там же знаходять зображення попереднього перегляду програми.
Також є додаток на Android, що використовує ті ж техногії і має ту ж зовнішню структуру в репозиторії YoutubeMPLoader.
Однак даний репозиторій не містить файл проєкту, а лише файли для відновлення і інструкцію для відновлення.

[preview](https://github.com/QiwiYesman/YoutubeExplodeUsing/blob/83a85cc7b8c0040307ddd6af63257486664c4b17/img_22.png)
