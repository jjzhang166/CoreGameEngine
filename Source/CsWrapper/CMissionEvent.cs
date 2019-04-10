/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CMissionEvent : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CMissionEvent(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CMissionEvent obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CMissionEvent() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_CMissionEvent(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public CMissionEvent() : this(testPINVOKE.new_CMissionEvent(), true) {
  }

  public CPlayer Owner {
    set {
      testPINVOKE.CMissionEvent_Owner_set(swigCPtr, CPlayer.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CMissionEvent_Owner_get(swigCPtr);
      CPlayer ret = (cPtr == IntPtr.Zero) ? null : new CPlayer(cPtr, false);
      return ret;
    } 
  }

  public CPlayer Killed {
    set {
      testPINVOKE.CMissionEvent_Killed_set(swigCPtr, CPlayer.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CMissionEvent_Killed_get(swigCPtr);
      CPlayer ret = (cPtr == IntPtr.Zero) ? null : new CPlayer(cPtr, false);
      return ret;
    } 
  }

  public CInventoryItem InventoryItem {
    set {
      testPINVOKE.CMissionEvent_InventoryItem_set(swigCPtr, CInventoryItem.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CMissionEvent_InventoryItem_get(swigCPtr);
      CInventoryItem ret = (cPtr == IntPtr.Zero) ? null : new CInventoryItem(cPtr, false);
      return ret;
    } 
  }

  public CProjectile Projectile {
    set {
      testPINVOKE.CMissionEvent_Projectile_set(swigCPtr, CProjectile.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CMissionEvent_Projectile_get(swigCPtr);
      CProjectile ret = (cPtr == IntPtr.Zero) ? null : new CProjectile(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void UserData {
    set {
      testPINVOKE.CMissionEvent_UserData_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CMissionEvent_UserData_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public MISSION_TYPE MissionType {
    set {
      testPINVOKE.CMissionEvent_MissionType_set(swigCPtr, (int)value);
    } 
    get {
      MISSION_TYPE ret = (MISSION_TYPE)testPINVOKE.CMissionEvent_MissionType_get(swigCPtr);
      return ret;
    } 
  }

}
