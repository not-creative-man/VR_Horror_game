using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_flicker : MonoBehaviour
{

    private Light _light;
    private float start_intensity;
    public float min_intensity;
    public float max_intensity;
    public float noise_speed = 0.15f;
    public bool flicker_ON;
    private bool random_timer;
    private float random_timer_value_MIN = 5f;
    private float random_timer_value_MAX = 20f;
    private float random_timer_value;
    private float start_timer_value = 0.1f;


    IEnumerator Start(){
        _light = GetComponent<Light>();
        start_intensity = _light.intensity;
        yield return new WaitForSeconds(start_timer_value);
        while(random_timer){
            random_timer_value = Random.Range(random_timer_value_MIN,random_timer_value_MAX);
            yield return new WaitForSeconds(random_timer_value);
            if(flicker_ON){
                _light.intensity = start_intensity;
                flicker_ON = false;
            }
            else{
                flicker_ON = true;
            }
        }
    }

    void Update(){
        if(flicker_ON) _light.intensity = Mathf.Lerp(min_intensity, max_intensity, Mathf.PerlinNoise(10, Time.time/noise_speed));
    }
}


