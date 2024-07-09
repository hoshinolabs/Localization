﻿using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace HoshinoLabs.ULocalization.Udon {
    [AddComponentMenu("")]
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class ILocalization : UdonSharpBehaviour {
        public virtual string[] AvailableLocales { get; }
        public virtual string ProjectLocale { get; }

        public virtual string SelectedLocale { get; set; }

        public virtual void RefreshString(object groupId) { }
        public virtual void RefreshAsset(object groupId) { }

        public virtual object GetVariable(object variableId) => null;
        public virtual void SetVariable(object variableId, object value) { }

        public virtual string GetLocalizedString(object groupId, string locale) => null;
        public virtual object GetLocalizedAsset(object groupId, string locale) => null;
        public virtual string GetLocalizedString(string locale, object assetId) => null;
        public virtual object GetLocalizedAsset(string locale, object assetId) => null;
    }
}
