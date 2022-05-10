chcp 65001 > nul
@set cam='Logi Capture'
ffmpeg -f dshow -show_video_device_dialog true -i video=%cam%
