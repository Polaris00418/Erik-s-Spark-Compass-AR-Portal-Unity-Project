//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Video;

//public class PortalControl : MonoBehaviour {
//	public VideoClip[] clips;
//	VideoPlayer mPlayer;
//	int _curVideoIndex;
//
//	public void NextVideo(){
//		if (++_curVideoIndex == clips.Length) {
//			_curVideoIndex = 0;
//		}
//		mPlayer = GameObject.FindObjectOfType<VideoPlayer> ();
//		if (mPlayer == null)
//			return;
//		mPlayer.Stop();
//		mPlayer.clip = clips[_curVideoIndex];
//		mPlayer.Play ();
//	}
//	public void PrevVideo(){
//		if (--_curVideoIndex == -1) {
//			_curVideoIndex = clips.Length - 1;
//		}
//		mPlayer = GameObject.FindObjectOfType<VideoPlayer> ();
//		mPlayer = GameObject.FindObjectOfType<VideoPlayer> ();
//		if (mPlayer == null)
//			return;
//		mPlayer.Stop();
//		mPlayer.clip = clips[_curVideoIndex];
//		mPlayer.Play ();
//	}
//
//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class PortalControl : MonoBehaviour {
	public string[] videoPaths;
	public MediaPlayer mPlayer;
	int _curVideoIndex;

	public void NextVideo(){
		if (++_curVideoIndex == videoPaths.Length) {
			_curVideoIndex = 0;
		}
		mPlayer.Stop();
		mPlayer.OpenVideoFromFile (MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder, videoPaths [_curVideoIndex]);
	}
	public void PrevVideo(){
		if (--_curVideoIndex == -1) {
			_curVideoIndex = videoPaths.Length - 1;
		}
		mPlayer.Stop();
		mPlayer.OpenVideoFromFile (MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder, videoPaths [_curVideoIndex]);
	}
	// Use this for initialization
	void Start () {
		_curVideoIndex = 1;
	}

	// Update is called once per frame
	void Update () {

	}
}
