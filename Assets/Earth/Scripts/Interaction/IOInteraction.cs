using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IOInteraction : MonoBehaviour {

	[SerializeField] private Camera cam;

	[SerializeField] private Transform earth;

	[SerializeField] private UIManager ui;

	void Update()
	{
		// Trigerred when the user press a button
		if(Input.GetButtonDown("Fire1"))
		{
			Ray r = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(r, out hitInfo, Mathf.Infinity, LayerMask.GetMask("Earth")))
			{
				// Get cartesian coordinates
				Vector3 cartesianCoord = earth.InverseTransformPoint(hitInfo.point).normalized;
				// Compute spherical coordinates
				Vector2 sphericalCoord = CoordinateFinder.CartesianToSphericalCoordinates(cartesianCoord);
				// Process
				string location = RestApiInterface.GoogleAPIProcessCoord(sphericalCoord);
                //WeatherData weatherData = RestApiInterface.WeatherMapProcessCoord (sphericalCoord);
                // Display resul
                ui.Update(location);
			} else
            {
                //reset ui
                ui.Update(null);
            }
		}
        else if (Input.GetButtonDown("Fire2")){
            //reset ui
            ui.Update(null);
        }
		// Escape -> quit 
		else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
