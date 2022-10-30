using UnityEngine;

namespace WJU3D {
    public class AutoSaveConfig : ScriptableObject {
        [Tooltip("启动自动保存功能")]
        public bool Enabled;

        [Tooltip("自动保存将在分钟频率中激活"), Min(1)]
        public int Frequency = 1;

        [Tooltip("每次场景被自动保存时，记录一条消息")]
        public bool Logging;
    }
}