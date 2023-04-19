using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Imporē, lai varētu darboties ar pointer interfeisu
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour,
    IPointerDownHandler, IBeginDragHandler, 
    IDragHandler, IEndDragHandler{
    public Canvas kanva;
    private RectTransform transformacijasLogs;

	// Use this for initialization
	void Start () {
        transformacijasLogs = GetComponent<RectTransform>();
	}
	
	public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log(
        "Izdarīts kreisais klikšķis uz velkama objekta!");
    }
	
    
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsākta objekta vikšana!");
    }

    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Notiek objekta vilkšana!");
        transformacijasLogs.anchoredPosition +=
            notikums.delta / kanva.scaleFactor; 
    }

    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Beigta objekta vilkšana!");
    }

}
