using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowReplay : MonoBehaviour {

    [SerializeField]
    private RawImage displaySurface;
    private bool playingReplay = false;
    [SerializeField]
    private Record RecordScript;
    private CapturedReplay replay;

    void Update()
    {
        if (playingReplay)
        {
            displaySurface.texture = replay.nextFrame();
        }
    }

    public void StartReplay()
    {
        replay = RecordScript.GetReplay();
        displaySurface.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, replay.GetWidth());
        displaySurface.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, replay.GetHeight());
        playingReplay = true;
    }

    public void StopReplay()
    {
        playingReplay = false;

    }
	
}
