using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class u6_slider_ctrl : MonoBehaviour
{
    private Slider slider1;
    private Slider slider2;
    private Slider slider3;
    private Slider slider4;
    private Slider slider5;
    private Slider slider6;
    [SerializeField] private GameObject parentJoint_1_Box;
    [SerializeField] private GameObject childJoint_2_Box;
    [SerializeField] private GameObject childJoint_3_Box;
    [SerializeField] private GameObject childJoint_4_Box;
    [SerializeField] private GameObject childJoint_5_Box;
    [SerializeField] private GameObject endEffJoint_6_Box;
    private float childJoint_2_OffsetX = (float)(-0.0754 / 1.0);
    private float childJoint_2_OffsetY = (float)(0.1124 / 1.0);
    private float childJoint_3_OffsetY = (float)(0.2858 / 1.0);
    private float childJoint_3_OffsetZ = (float)(0.053 / 1.0);
    private float childJoint_4_OffsetX = (float)(0.068 / 1.0);
    private float childJoint_4_OffsetY = (float)(-0.171 / 1.0);
    private float childJoint_4_OffsetZ = (float)(0.08 / 1.0);
    private float childJoint_5_OffsetY = (float)(-.172 / 1.0);
    private float endEffJoint_6_OffsetY = (float)(-0.07 / 1.0);
    private float endEffJoint_6_OffsetZ = (float)(0.075 / 1.0);

    void Start()
    {
        slider1 = GameObject.Find("Slider1").GetComponent<Slider>();
        slider2 = GameObject.Find("Slider2").GetComponent<Slider>();
        slider3 = GameObject.Find("Slider3").GetComponent<Slider>();
        slider4 = GameObject.Find("Slider4").GetComponent<Slider>();
        slider5 = GameObject.Find("Slider5").GetComponent<Slider>();
        slider6 = GameObject.Find("Slider6").GetComponent<Slider>();
    }

    public void AlterJoints()
    {
        float rotationValue1 = slider1.value * 360f;
        float rotationValue2 = slider2.value * 360f;
        float rotationValue3 = slider3.value * 360f;
        float rotationValue4 = slider4.value * 360f;
        float rotationValue5 = slider5.value * 360f;
        float rotationValue6 = slider6.value * 360f;
        // Set the parent's rotation
        if (slider1.value > 0f)
        {
            AlterJointWithVariablesfrom_Joint_1(rotationValue1, parentJoint_1_Box, Vector3.zero);
            // Set the childJoint_2_Box's parent to parentJoint_1_Box
            SetParentAndAlterJointWithVariables(childJoint_2_Box, parentJoint_1_Box, childJoint_2_OffsetX, childJoint_2_OffsetY, 0f);
            // Set the childJoint_3_Box's parent to childJoint_2_Box
            SetParentAndAlterJointWithVariables(childJoint_3_Box, childJoint_2_Box, 0f, childJoint_3_OffsetY, childJoint_3_OffsetZ);
            // Set the childJoint_4_Box's parent to childJoint_3_Box
            SetParentAndAlterJointWithVariables(childJoint_4_Box, childJoint_3_Box, childJoint_4_OffsetX, childJoint_4_OffsetY, childJoint_4_OffsetZ);
            // Set the childJoint_5_Box's parent to childJoint_4_Box
            SetParentAndAlterJointWithVariables(childJoint_5_Box, childJoint_4_Box, 0f, childJoint_5_OffsetY, 0f);
            // Set the endEffJoint_6_Box's parent to childJoint_5_Box
            SetParentAndAlterJointWithVariables(endEffJoint_6_Box, childJoint_5_Box, 0f, endEffJoint_6_OffsetY, endEffJoint_6_OffsetZ);
        }
        if (slider2.value > 0f)
        {
            // AlterJointWithVariablesfromJoint2(rotationValue2, childJoint_2_Box, Vector3.zero);
            // AlterJointWithVariablesfromJoint2(rotationValue2, childJoint_2_Box, new Vector3(0f, 0f, 0f));
            AlterJointWithVariablesfrom_Joint_2_AND_3_AND_5(rotationValue2, childJoint_2_Box, new Vector3(childJoint_2_OffsetX, childJoint_2_OffsetY, 0f));
            // Set the childJoint_3_Box's parent to childJoint_2_Box
            SetParentAndAlterJointWithVariables(childJoint_3_Box, childJoint_2_Box, 0f, childJoint_3_OffsetY, childJoint_3_OffsetZ);
            // Set the childJoint_4_Box's parent to childJoint_3_Box
            SetParentAndAlterJointWithVariables(childJoint_4_Box, childJoint_3_Box, childJoint_4_OffsetX, childJoint_4_OffsetY, childJoint_4_OffsetZ);
            // Set the childJoint_5_Box's parent to childJoint_4_Box
            SetParentAndAlterJointWithVariables(childJoint_5_Box, childJoint_4_Box, 0f, childJoint_5_OffsetY, 0f);
            // Set the endEffJoint_6_Box's parent to childJoint_5_Box
            SetParentAndAlterJointWithVariables(endEffJoint_6_Box, childJoint_5_Box, 0f, endEffJoint_6_OffsetY, endEffJoint_6_OffsetZ);
        }
        if (slider3.value > 0f)
        {
            // AlterJointWithVariablesfromJoint2(rotationValue2, childJoint_2_Box, Vector3.zero);
            // AlterJointWithVariablesfromJoint2(rotationValue2, childJoint_2_Box, new Vector3(0f, 0f, 0f));
            AlterJointWithVariablesfrom_Joint_2_AND_3_AND_5(rotationValue3, childJoint_3_Box, new Vector3(0f, childJoint_3_OffsetY, childJoint_3_OffsetZ));
            // Set the childJoint_4_Box's parent to childJoint_3_Box
            SetParentAndAlterJointWithVariables(childJoint_4_Box, childJoint_3_Box, childJoint_4_OffsetX, childJoint_4_OffsetY, childJoint_4_OffsetZ);
            // Set the childJoint_5_Box's parent to childJoint_4_Box
            SetParentAndAlterJointWithVariables(childJoint_5_Box, childJoint_4_Box, 0f, childJoint_5_OffsetY, 0f);
            // Set the endEffJoint_6_Box's parent to childJoint_5_Box
            SetParentAndAlterJointWithVariables(endEffJoint_6_Box, childJoint_5_Box, 0f, endEffJoint_6_OffsetY, endEffJoint_6_OffsetZ);
        }
        if (slider4.value > 0f)
        {
            // AlterJointWithVariablesfromJoint2(rotationValue2, childJoint_2_Box, Vector3.zero);
            // AlterJointWithVariablesfromJoint2(rotationValue2, childJoint_2_Box, new Vector3(0f, 0f, 0f));
            AlterJointWithVariablesfrom_Joint_4_AND_6(rotationValue4, childJoint_4_Box, new Vector3(childJoint_4_OffsetX, childJoint_4_OffsetY, childJoint_4_OffsetZ));
            // Set the childJoint_5_Box's parent to childJoint_4_Box
            SetParentAndAlterJointWithVariables(childJoint_5_Box, childJoint_4_Box, 0f, childJoint_5_OffsetY, 0f);
            // Set the endEffJoint_6_Box's parent to childJoint_5_Box
            SetParentAndAlterJointWithVariables(endEffJoint_6_Box, childJoint_5_Box, 0f, endEffJoint_6_OffsetY, endEffJoint_6_OffsetZ);
        }
        if (slider5.value > 0f)
        {
            // AlterJointWithVariablesfromJoint2(rotationValue2, childJoint_2_Box, Vector3.zero);
            // AlterJointWithVariablesfromJoint2(rotationValue2, childJoint_2_Box, new Vector3(0f, 0f, 0f));
            AlterJointWithVariablesfrom_Joint_2_AND_3_AND_5(rotationValue5, childJoint_5_Box, new Vector3(0f, childJoint_5_OffsetY, 0f));
            // Set the endEffJoint_6_Box's parent to childJoint_5_Box
            SetParentAndAlterJointWithVariables(endEffJoint_6_Box, childJoint_5_Box, 0f, endEffJoint_6_OffsetY, endEffJoint_6_OffsetZ);
        }
        if (slider6.value > 0f)
        {
            // AlterJointWithVariablesfromJoint2(rotationValue2, childJoint_2_Box, Vector3.zero);
            // AlterJointWithVariablesfromJoint2(rotationValue2, childJoint_2_Box, new Vector3(0f, 0f, 0f));
            AlterJointWithVariablesfrom_Joint_4_AND_6(rotationValue6, endEffJoint_6_Box, new Vector3(0f, endEffJoint_6_OffsetY, endEffJoint_6_OffsetZ));
        }

    }

    private void SetParentAndAlterJointWithVariables(GameObject child, GameObject newParent, float X, float Y, float Z)
    {
        if (child != null && newParent != null)
        {
            // Set the parent of the child
            child.transform.SetParent(newParent.transform, false);
            // Adjust local scale to prevent unexpected scaling
            child.transform.localScale = Vector3.one;
            // Alter the local position of the child
            child.transform.localPosition = new Vector3(X, Y, Z);
            // Alter joint rotation
            AlterJointWithVariablesfrom_Joint_1(0f, child, new Vector3(X, Y, Z));
        }
        else
        {
            Debug.LogError("Child or newParent is null. Please assign them in the Unity Editor.");
        }
    }

    public void AlterJointWithVariablesfrom_Joint_1(float rotationValue_1, GameObject jointBox, Vector3 offset)
    {
        if (jointBox != null)
        {
            Transform jointTransform = jointBox.transform;
            jointTransform.localRotation = Quaternion.Euler(0, rotationValue_1, 0);
            jointTransform.localPosition = offset;
        }
        else
        {
            Debug.LogError("Joint box is null. Please assign it in the Unity Editor.");
        }
    }

    public void AlterJointWithVariablesfrom_Joint_2_AND_3_AND_5(float rotationValue_2_3_5, GameObject jointBox, Vector3 offset)
    {
        if (jointBox != null)
        {
            Transform jointTransform = jointBox.transform;
            jointTransform.localRotation = Quaternion.Euler(rotationValue_2_3_5, 0, 0);
            jointTransform.localPosition = offset;
        }
        else
        {
            Debug.LogError("Joint box is null. Please assign it in the Unity Editor.");
        }
    }
    public void AlterJointWithVariablesfrom_Joint_4_AND_6(float rotationValue_4_6, GameObject jointBox, Vector3 offset)
    {
        if (jointBox != null)
        {
            Transform jointTransform = jointBox.transform;
            jointTransform.localRotation = Quaternion.Euler(0, rotationValue_4_6, 0);
            jointTransform.localPosition = offset;
        }
        else
        {
            Debug.LogError("Joint box is null. Please assign it in the Unity Editor.");
        }
    }
}

