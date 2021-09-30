using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SystemMapper.DataTypes;

namespace SystemMapper.SystemElements
{
    public class SystemIOElement : SystemElement
    {
        #region Declarations

        /// <summary>
        /// The data type of this <see cref="SystemIOElement"/>
        /// </summary>
        public S_DataType dataType;

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

        /// <summary>
        /// Converts a <see cref="S_DataType"/> to a <see cref="Type"/>
        /// </summary>
        public Type ConvertS_DataType(S_DataType dataType)
        {
            switch (dataType.type)
            {
                case S_DType.INT:
                    return typeof(int);
                case S_DType.FLOAT:
                    return typeof(float);
                case S_DType.DOUBLE:
                    return typeof(double);
                case S_DType.CHAR:
                    return typeof(char);
                case S_DType.STRING:
                    return typeof(string);
                default:
                    return null;
            }
        }

        #endregion
    }
}