using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SystemMapper.DataTypes
{
    public class S_DataType : MonoBehaviour
    {
        #region Declarations

        public S_DType type;

        #endregion

        #region Unity Methods

        void Awake()
        {

        }

        void Start()
        {

        }

        void Update()
        {

        }

        #endregion

        #region Custom Methods

        #endregion
    }

    public enum S_DType {
        INT, FLOAT, DOUBLE, CHAR, STRING 
    }
}