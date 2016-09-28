Play 360 Videos in Unity
=====

Unity Version: 5.3.4f1 Personal

[Step-by-step slide](https://docs.google.com/presentation/d/1EwCJ_e_stUCfR142Ao6pbruDEHhhW86D-r4YEEQ7Ses/edit?usp=sharing) [Google Slides]

## Play video with MovieTexture

Adapted from [Bernie Roehla](http://bernieroehl.com/360stereoinunity/).

1. Move **Main Camera** to `X = 0, Y = 0, Z = 0`.
2. Create a **Sphere** at `X = 0, Y = 0, Z = 0` and scale `X = 10, Y = 10, Z = 10`, rename it to **VideoSphere**.
3. Create an empty material and drag to **VideoSphere**.
4. Create a new shader `InsideVisible.shader` so the texture can be rendered inside the sphere. Drag it to material in **VideoSphere**.
5. Drag the 360 video to Assets and drag it to texture of **Material** in **VideoSphere**.
6. Create an empty **GameObject** and add a script `VideoPlayback.cs` to playback the video. Assign **Sphere** to **VideoSphere**.
7. Click Play, now you can play the video.
8. For sound, click on **GameObject** and **Add Component**, then type in **Audio Source**. Choose the same video for **AudioClip**. Now you have sound sync to the video!

## Stream 360 camera

Hardware: Ricoh Theta S

1. While holding the camera icon button, press power button to go to LIVE stream mode. Then connect it to computer via USB.
2. Install RICOH THETA UVC Blender (Mac, Win)
3. `WebCamStream.cs` streams webcam according to **Camera Number**. You can check the Unity console for the index, for example:

        Device 0: RICOH THETA S - original dual fisheye views
        Device 1: THETA UVC Blender - equirectangular view <- use this device
        Device 2: FaceTime HD Camera

## 360 Video Format

- MP4/MOV format video at most 1280x640 resolution (might need to wait 10+min when importing); Unity native OGG format video can run up to 3840x1920.

  You can convert the video by the following on Linux:

        ffmpeg -i INPUT.mp4 -c:v libtheora -c:a libvorbis -q:v 6 -q:a 5 OUTPUT.ogg

- Unity built-in MovieTexture does not support mobile platforms (iOS, Android).
- [AVPro Video](http://renderheads.com/product/avpro-video/) plugin ($450) provides good support for mobile and high resolution videos.

## 360 Video Source

- The video in this example: [Pokèmon 360 - CATCH 'EM ALL in VR!](https://www.youtube.com/watch?v=pHUVS_GrIeM) by Freakin Rad.
- [youtude-dl](https://rg3.github.io/youtube-dl/) is a great program to download YouTube video including 360 videos.
