using UnityEngine;

internal class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    private bool destroyOnlyComponent;

    public static T Instance {
        get => _instance;
        private protected set => _instance = value;
    }

    private static T _instance;
    private bool _isInitialized;
    
    private protected virtual void Awake() {
        if(Instance != this) {
            Destroy(destroyOnlyComponent ? (Object)this : gameObject);
        }
        else if (_isInitialized) {
            SetUp();
        }
    }
    private void SetUp() {
        _isInitialized = true;
    }
}
