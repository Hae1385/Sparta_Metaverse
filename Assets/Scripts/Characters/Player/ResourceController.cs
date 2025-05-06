using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceController : MonoBehaviour
{
    private BaseController baseController;

    private void Awake()
    {
        baseController = GetComponent<BaseController>();
    }


}
