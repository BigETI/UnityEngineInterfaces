using System.Security;

/// <summary>
/// Unity Engine namespace
/// </summary>
namespace UnityEngine
{
    /// <summary>
    /// An interface that represents an Unity object
    /// </summary>
    public interface IObject
    {
        /// <summary>
        /// Should the object be hidden, saved with the Scene or modifiable by the user?
        /// </summary>
        HideFlags hideFlags { get; set; }

        /// <summary>
        /// The name of the object.
        /// </summary>
        string name { get; set; }

        bool Equals(object other);

        int GetHashCode();

        /// <summary>
        /// Gets the instance ID of the object.
        /// </summary>
        /// <returns> Returns the instance ID of the object. When used to call the origin object, this method returns a positive value. When used to call the instance object, this method returns a negative value.</returns>
        [SecuritySafeCritical]
        int GetInstanceID();

        /// <summary>
        /// Returns the name of the object.
        /// </summary>
        /// <returns>The name returned by ToString.</returns>
        string ToString();
    }
}
