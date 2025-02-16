using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {

        if (!triggeredBody.CompareTag("Ball")) return;
        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();
        float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;
        ballRigidBody.linearVelocity = Vector3.zero;
        ballRigidBody.angularVelocity = Vector3.zero;
        if (ballRigidBody.isKinematic) return;
        ballRigidBody.AddForce(Vector3.forward * velocityMagnitude, ForceMode.VelocityChange);
    }
}