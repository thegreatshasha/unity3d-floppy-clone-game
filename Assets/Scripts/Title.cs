using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	void Start () {
        guiText.fontSize = Mathf.RoundToInt(Camera.main.pixelHeight / 14f);
		HTTP.Request someRequest = new HTTP.Request("get", "http://api.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=44db6a862fba0b067b1930da0d769e98");
		someRequest.Send( ( request ) => {
			// parse some JSON, for example:
			JSONObject thing = new JSONObject( request.response.Text );
			Debug.Log(thing);
		});
	}

}
