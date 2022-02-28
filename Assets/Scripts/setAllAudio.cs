using System.Collections.Generic;
using UnityEngine;

public class setAllAudio : MonoBehaviour
{
    List<AudioSource> _audios = null;
    Data _data = Data.getInstance();

    public void setAudio()
    {
        _audios = new List<AudioSource>(GameObject.FindObjectsOfType<AudioSource>());

        foreach (AudioSource tmp in _audios)
            tmp.volume = _data.json.volume;
    }
}
