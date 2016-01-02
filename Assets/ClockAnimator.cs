using UnityEngine;
using System.Collections;
using System;

public class ClockAnimator : MonoBehaviour {

	private const float hoursToDegrees = 360f / 12f;
	private const float minutesToDegrees = 360f/60f;
	private const float secondsToDegrees = 360f/60;
	private const float millisecondsToDegrees = 360f/1000;

	public Transform hours, minutes, seconds, milliseconds;
	public bool analog;

	private void Update () {
		if (analog) 
		{
			TimeSpan timespan = DateTime.Now.TimeOfDay;
			hours.localRotation = Quaternion.Euler (0, 0, (float)timespan.TotalHours * -hoursToDegrees);
			minutes.localRotation = Quaternion.Euler (0, 0, (float)timespan.TotalMinutes * -minutesToDegrees);
			seconds.localRotation = Quaternion.Euler (0, 0, (float)timespan.TotalSeconds * -secondsToDegrees);
			milliseconds.localRotation = Quaternion.Euler(0,0,(float)timespan.TotalMilliseconds * -millisecondsToDegrees);


		} 
		else {
			DateTime time = DateTime.Now;

			hours.localRotation = Quaternion.Euler (0, 0, time.Hour * -hoursToDegrees);
			minutes.localRotation = Quaternion.Euler (0, 0, time.Minute * -minutesToDegrees);
			seconds.localRotation = Quaternion.Euler (0, 0, time.Second * -secondsToDegrees);
			milliseconds.localRotation = Quaternion.Euler(0,0,time.Millisecond * -millisecondsToDegrees);
		}
	}
}
