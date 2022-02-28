using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Volume : MonoBehaviour
{

    List<AudioSource> _audios = null;

    Slider _listenerVolume = null;

    Data _data = Data.getInstance();

    private void Awake()
    {
        _listenerVolume = GetComponentInChildren<Slider>();
        setAudio();
    }

    public void setAudio()
    {
        _listenerVolume.value = _data.json.volume;
        _audios = new List<AudioSource>(GameObject.FindObjectsOfType<AudioSource>());

        foreach (AudioSource tmp in _audios)
            tmp.volume = _data.json.volume;
    }

    public void setVolume(float vol)
    {
        if (_audios != null)
            foreach (AudioSource tmp in _audios)
                tmp.volume = vol;

        _data.json.volume = vol;
    }
}
