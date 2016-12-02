using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CapturedReplay
{
	private List<RenderTexture> m_Frames;
    private int FramesPerSecond;
    private int m_Width;
    private int m_Height;
    private int numFrames = 0;
    private int currentframe = 0;

    public CapturedReplay(Queue<RenderTexture> frames, int fps, int width, int height)
    {
        m_Frames = new List<RenderTexture>();

        Queue<RenderTexture> tempQueue = new Queue<RenderTexture>(frames);

        Debug.Log("frames.count = " + frames.Count);
        while (tempQueue.Count > 0)
        {
            Debug.Log("frames.count = " + frames.Count);
            Debug.Log("m_frames" + m_Frames);
            m_Frames.Add(tempQueue.Dequeue());
        }
        FramesPerSecond = fps;
        m_Width = width;
        m_Height = height;
        numFrames = m_Frames.Count;
    }



    public RenderTexture nextFrame()
    {
        int tempFrame = currentframe;
        currentframe = (currentframe + 1) % m_Frames.Count;
                
        return m_Frames[tempFrame];

    }

    public int GetWidth()
    {
        return m_Width;
    }

    public int GetHeight()
    {
        return m_Height;
    }

    public int GetFPS()
    {
        return FramesPerSecond;
    }


}
