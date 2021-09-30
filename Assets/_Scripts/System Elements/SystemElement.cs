using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SystemMapper.SystemElements
{
    public class SystemElement : MonoBehaviour
    {
        #region Declarations

        /// <summary>
        /// The summary of this <see cref="SystemElement"/>
        /// </summary>
        public string summary;

        /// <summary>
        /// The UI Text element for <see cref="summary"/>
        /// </summary>
        public TMP_Text summaryText;

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
        /// Sets <see cref="summary"/> to the text of <see cref="summaryText"/>
        /// </summary>
        public void SetSummary()
        {
            summary = summaryText.text;
        }

        #endregion
    }
}