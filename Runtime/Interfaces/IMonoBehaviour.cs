using System.Collections;
using UnityEngine.Internal;

/// <summary>
/// Unity Engine namespace
/// </summary>
namespace UnityEngine
{
    /// <summary>
    /// An interface that represents a Mono behaviour
    /// </summary>
    public interface IMonoBehaviour : IObject
    {
        /// <summary>
        /// Disabling this lets you skip the GUI layout phase.
        /// </summary>
        bool useGUILayout { get; set; }

        /// <summary>
        /// Allow a specific instance of a MonoBehaviour to run in edit mode (only available in the editor).
        /// </summary>
        bool runInEditMode { get; set; }

        /// <summary>
        /// Logs message to the Unity Console (identical to Debug.Log).
        /// </summary>
        /// <param name="methodName">Method name</param>
        void CancelInvoke(string methodName);

        /// <summary>
        /// Cancels all Invoke calls on this MonoBehaviour.
        /// </summary>
        void CancelInvoke();

        /// <summary>
        /// Invokes the method methodName in time seconds.
        /// </summary>
        /// <param name="methodName">Method name</param>
        /// <param name="time">Time</param>
        void Invoke(string methodName, float time);

        /// <summary>
        /// Invokes the method methodName in time seconds, then repeatedly every repeatRate seconds.
        /// </summary>
        /// <param name="methodName">Method name</param>
        /// <param name="time">Time</param>
        /// <param name="repeatRate">Repeat rate</param>
        void InvokeRepeating(string methodName, float time, float repeatRate);

        /// <summary>
        /// Is any invoke on methodName pending?
        /// </summary>
        /// <param name="methodName">Method name</param>
        /// <returns></returns>
        bool IsInvoking(string methodName);

        /// <summary>
        /// Is any invoke pending on this MonoBehaviour?
        /// </summary>
        /// <returns></returns>
        bool IsInvoking();

        /// <summary>
        /// Starts a coroutine named methodName.
        /// </summary>
        /// <param name="methodName">Method name</param>
        /// <returns></returns>
        [ExcludeFromDocs]
        Coroutine StartCoroutine(string methodName);

        /// <summary>
        /// Starts a Coroutine.
        /// </summary>
        /// <param name="routine">Routine</param>
        /// <returns></returns>
        Coroutine StartCoroutine(IEnumerator routine);

        /// <summary>
        /// Starts a coroutine named methodName.
        /// </summary>
        /// <param name="methodName">Method name</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value);

        /// <summary>
        /// Stops all coroutines running on this behaviour.
        /// </summary>
        void StopAllCoroutines();

        /// <summary>
        /// Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour.
        /// </summary>
        /// <param name="routine">Name of the function in code, including coroutines.</param>
        void StopCoroutine(IEnumerator routine);

        /// <summary>
        /// Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour.
        /// </summary>
        /// <param name="routine">Name of the function in code, including coroutines.</param>
        void StopCoroutine(Coroutine routine);

        /// <summary>
        /// Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour.
        /// </summary>
        /// <param name="methodName">Name of coroutine.</param>
        void StopCoroutine(string methodName);
    }
}
