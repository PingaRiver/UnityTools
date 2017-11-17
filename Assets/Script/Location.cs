using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour {

    [System.Serializable]
    public struct locStruct
    {
        public string locationName;
        public GameObject location;

        public locStruct(string LocationName, GameObject Location)
        {
            locationName = LocationName;
            location = Location;
        }
    }

    [SerializeField] public locStruct[] Locations;
    private locStruct currentLocation;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < Locations.Length; i++)
        {
            if (Locations[i].location.activeSelf)
            {
                currentLocation = Locations[i];
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchLocation(string newLocation)
    {
        currentLocation.location.SetActive(false);

        for (int i = 0; i < Locations.Length; i++)
        {
            if (Locations[i].locationName == newLocation)
            {
                currentLocation = Locations[i];
            }
        }

        currentLocation.location.SetActive(true);
    }
}
