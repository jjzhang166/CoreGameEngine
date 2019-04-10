/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CItemsManager : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CItemsManager(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CItemsManager obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CItemsManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_CItemsManager(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static CItemsManager Instance() {
    IntPtr cPtr = testPINVOKE.CItemsManager_Instance();
    CItemsManager ret = (cPtr == IntPtr.Zero) ? null : new CItemsManager(cPtr, false);
    return ret;
  }

  public void Update(SWIGTYPE_p_f32 elapsedTime) {
    testPINVOKE.CItemsManager_Update(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetItemProfiles(SWIGTYPE_p_VectorT_Core__CItemProfile_p_t List) {
    testPINVOKE.CItemsManager_GetItemProfiles(swigCPtr, SWIGTYPE_p_VectorT_Core__CItemProfile_p_t.getCPtr(List));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public CItemProfile GetItemProfile(string ProfileName) {
    IntPtr cPtr = testPINVOKE.CItemsManager_GetItemProfile(swigCPtr, ProfileName);
    CItemProfile ret = (cPtr == IntPtr.Zero) ? null : new CItemProfile(cPtr, false);
    return ret;
  }

  public void GetPlacedItems(SWIGTYPE_p_VectorT_Core__CInventoryItem_p_t List) {
    testPINVOKE.CItemsManager_GetPlacedItems(swigCPtr, SWIGTYPE_p_VectorT_Core__CInventoryItem_p_t.getCPtr(List));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public CInventoryItem Pickup(string ItemName) {
    IntPtr cPtr = testPINVOKE.CItemsManager_Pickup(swigCPtr, ItemName);
    CInventoryItem ret = (cPtr == IntPtr.Zero) ? null : new CInventoryItem(cPtr, false);
    return ret;
  }

  public CInventoryItem PickupUnplaced(string ProfileName) {
    IntPtr cPtr = testPINVOKE.CItemsManager_PickupUnplaced(swigCPtr, ProfileName);
    CInventoryItem ret = (cPtr == IntPtr.Zero) ? null : new CInventoryItem(cPtr, false);
    return ret;
  }

  public bool PlaceItem(string ProfileName, SWIGTYPE_p_Vector3 Position, SWIGTYPE_p_Core__Physics__IPhysicsStrategy Physics) {
    bool ret = testPINVOKE.CItemsManager_PlaceItem__SWIG_0(swigCPtr, ProfileName, SWIGTYPE_p_Vector3.getCPtr(Position), SWIGTYPE_p_Core__Physics__IPhysicsStrategy.getCPtr(Physics));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool PlaceItem(string ProfileName, SWIGTYPE_p_Vector3 Position) {
    bool ret = testPINVOKE.CItemsManager_PlaceItem__SWIG_1(swigCPtr, ProfileName, SWIGTYPE_p_Vector3.getCPtr(Position));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveItem(CInventoryItem InventoryItem) {
    testPINVOKE.CItemsManager_RemoveItem(swigCPtr, CInventoryItem.getCPtr(InventoryItem));
  }

  public void AddProfile(CItemProfile Profile) {
    testPINVOKE.CItemsManager_AddProfile__SWIG_0(swigCPtr, CItemProfile.getCPtr(Profile));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddProfile(CWeaponProfile Profile) {
    testPINVOKE.CItemsManager_AddProfile__SWIG_1(swigCPtr, CWeaponProfile.getCPtr(Profile));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Shutdown() {
    testPINVOKE.CItemsManager_Shutdown(swigCPtr);
  }

}
