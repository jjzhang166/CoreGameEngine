/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class GAMEOBJECT : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GAMEOBJECT(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GAMEOBJECT obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GAMEOBJECT() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_GAMEOBJECT(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_String Parent {
    set {
      testPINVOKE.GAMEOBJECT_Parent_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.GAMEOBJECT_Parent_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String Name {
    set {
      testPINVOKE.GAMEOBJECT_Name_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.GAMEOBJECT_Name_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String MeshFile {
    set {
      testPINVOKE.GAMEOBJECT_MeshFile_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.GAMEOBJECT_MeshFile_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_Quaternion Orientation {
    set {
      testPINVOKE.GAMEOBJECT_Orientation_set(swigCPtr, SWIGTYPE_p_Quaternion.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Quaternion ret = new SWIGTYPE_p_Quaternion(testPINVOKE.GAMEOBJECT_Orientation_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector3 Position {
    set {
      testPINVOKE.GAMEOBJECT_Position_set(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.GAMEOBJECT_Position_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector3 Scale {
    set {
      testPINVOKE.GAMEOBJECT_Scale_set(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.GAMEOBJECT_Scale_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool Shadows {
    set {
      testPINVOKE.GAMEOBJECT_Shadows_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.GAMEOBJECT_Shadows_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_String ObstacleType {
    set {
      testPINVOKE.GAMEOBJECT_ObstacleType_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.GAMEOBJECT_ObstacleType_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String PhysicsProfileName {
    set {
      testPINVOKE.GAMEOBJECT_PhysicsProfileName_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.GAMEOBJECT_PhysicsProfileName_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public GAMEOBJECT() : this(testPINVOKE.new_GAMEOBJECT(), true) {
  }

}
