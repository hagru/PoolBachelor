chcp 65001 > nul
@set cam='FaceTime HD Camera'
ffmpeg -f dshow -show_video_device_dialog true -i video=%cam%
