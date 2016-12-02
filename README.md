# MomentsPreview

This is a modified version of [Thomas Hourdel](https://github.com/Chman)'s **Moments** GIF Recorder for Unity.

**Moments** is a quick GIF replay recorder for Unity3D. It automatically records the last few seconds of gameplay and lets you save to a GIF file on demand, like the game [TowerFall Ascension](http://www.towerfall-game.com/) does.

**MomentsPreview** adds code to allow you to copy the queue of RenderTextures that **Moments** uses to buffer and generate its GIFS, as well as all necessary playback information. You can then use this set of RenderTextures to display a preview of the GIF by cycling through the RenderTextures on a RawImage UI element. The demo in **MomentsPreview** currently does not account for playback speed, but the CapturedReplay object contains all the necessary data and accessor methods to adjust playback speed.

Tested with Unity 5.4.

## Instructions

Drop the `Moments Recorder` folder in your project and add the `Recorder` script to your camera (or select your camera and use `Component -> Miscellaneous -> Moments Recorder`).

The included demo should get you started. For more advanced features, browse the `Moments.Recorder` source code, it's heavily commented.

[Here's a preview](http://i.imgur.com/K4R8UZ0.gifv) of the output quality.

## License

Zlib (see [License.txt](LICENSE.txt))
