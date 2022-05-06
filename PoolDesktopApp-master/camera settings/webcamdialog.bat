chcp 65001 > nul
set cam="Logitech StreamCam"
ffmpeg -f dshow -show_video_device_dialog true -i video=%cam%
