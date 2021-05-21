using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Radar : MonoBehaviour
{
    [SerializeField] private List<contactMarkerPairs> contacts;
    [SerializeField] private GameObject hostileMarker;
    [SerializeField] private Transform displayContainer, RadarBG;
    [SerializeField] private float maxBounds;
    Vector3 radarScale = new Vector3(0.5f, 0.5f, 0.5f);

    [Serializable]struct contactMarkerPairs
	{
        public ushort objectID;
        public GameObject contact;
        public Transform marker;
        public Transform tracker;
	}

    Vector3 ConvertedRelativePosistion(Vector3 targetPosition)
	{
        Vector3 tempPos = targetPosition - transform.position;
        tempPos = Vector3.Scale(tempPos, radarScale);
        tempPos = Vector3.ClampMagnitude(tempPos, maxBounds);
        return tempPos;
	}

    void RegisterContact(Transform contact)
	{

	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < contacts.Count; i++)
		{
            contacts[i].tracker.position = contacts[i].contact.transform.position;
            contacts[i].marker.localPosition = ConvertedRelativePosistion(contacts[i].tracker.localPosition);
            contacts[i].marker.rotation = contacts[i].contact.transform.rotation;
        }
        RadarBG.LookAt(Camera.main.transform.position, transform.up);
    }
}
