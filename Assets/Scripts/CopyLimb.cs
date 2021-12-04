using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyLimb : MonoBehaviour
{
    [SerializeField] private Transform targetLimb;

    [SerializeField] private ConfigurableJoint m_configurableJoint;

    Quaternion targetInitialRotation;
    void Start()
    {
        this.m_configurableJoint = this.GetComponent<ConfigurableJoint>();
        this.targetInitialRotation = this.targetLimb.transform.localRotation;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.m_configurableJoint.targetRotation = copyRotation();
    }

    private Quaternion copyRotation()
    {
        return Quaternion.Inverse(this.targetLimb.localRotation) * this.targetInitialRotation;
    }
}
