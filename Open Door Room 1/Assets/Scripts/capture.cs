using UnityEngine;
using System.Collections;

// capture frames as a screenshot sequence. Images are
// stored as PNG files in a folder - these can be combined into
// a movie using image utility software (eg, QuickTime Pro, Photoshop, FFmpeg).

public class capture : MonoBehaviour {

	// the folder to contain our screenshots
	public string folder = "ScreenshotFolder";

	// desired framerate of resulting video
	// how many times per second should we capture frames?
	public int frameRate = 30;

	// keep track of which frame we are on, starting at 0
	private int frameNum = 0;

	void Start() {

		// set the playback framerate (real time will not relate to game time after this).
		Time.captureFramerate = frameRate;

		// create the folder (fancy C#)
		System.IO.Directory.CreateDirectory(folder);
	}


	void Update() {

		// ** remember, Update() gets called every frame **

		// more fancy C#
		// append filename to folder name (format is 'frame0005.png')
		string name = string.Format("{0}/frame{1:D04}.png", folder, frameNum);

		// next frame #
		frameNum++;

		// capture the screenshot to the specified file
		ScreenCapture.CaptureScreenshot(name);
	}
}