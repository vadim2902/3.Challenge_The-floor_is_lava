using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

  public GameObject Sphere; 
  private Vector3 offset;  

  void Start () 
  {     
    offset = transform.position - Sphere.transform.position;
  }

  void LateUpdate () 
  {     
    transform.LookAt(Sphere.transform);
  }
}
