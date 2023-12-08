using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    public AudioSource teleportSound;
    void OnTriggerEnter(Collider other) {
        teleportSound.Play(); //ещё звук телепортаций такой вжух
        other.transform.position = teleportPoint.position;
    }
}
