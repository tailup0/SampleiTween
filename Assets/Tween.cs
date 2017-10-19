using UnityEngine;
using System.Collections;

public class Tween : MonoBehaviour {

    GameObject obj;
    Vector3 scale;

    // Use this for initialization
    void Start () {
      obj = this.gameObject;
      scale = obj.transform.localScale;
    }
    public void MoveRight(){
      iTween.MoveTo (obj, iTween.Hash ("x", obj.transform.position.x+2, "time", 3));
    }
    public void MoveLeft(){
      iTween.MoveTo (obj, iTween.Hash ("x", obj.transform.position.x-2, "time", 3));
    }
    public void Scale(){
      iTween.ScaleTo (obj, iTween.Hash ("x", scale.x+1, "y", scale.y+1, "z", scale.z+1, "time", 3));
      scale = obj.transform.localScale;
    }
    public void Rotate(){
      iTween.RotateTo (obj, iTween.Hash ("x", 90, "time", 3));
    }
}
