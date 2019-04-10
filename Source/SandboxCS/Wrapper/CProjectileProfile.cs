/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CProjectileProfile : CItemProfile {
  private HandleRef swigCPtr;

  internal CProjectileProfile(IntPtr cPtr, bool cMemoryOwn) : base(testPINVOKE.CProjectileProfile_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CProjectileProfile obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CProjectileProfile() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_CProjectileProfile(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CProjectileProfile() : this(testPINVOKE.new_CProjectileProfile(), true) {
  }

  public SWIGTYPE_p_f32 Damage {
    set {
      testPINVOKE.CProjectileProfile_Damage_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CProjectileProfile_Damage_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 Speed {
    set {
      testPINVOKE.CProjectileProfile_Speed_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CProjectileProfile_Speed_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String BillboardBullet {
    set {
      testPINVOKE.CProjectileProfile_BillboardBullet_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.CProjectileProfile_BillboardBullet_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String BillboardFlash {
    set {
      testPINVOKE.CProjectileProfile_BillboardFlash_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.CProjectileProfile_BillboardFlash_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool isPenetrate {
    set {
      testPINVOKE.CProjectileProfile_isPenetrate_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.CProjectileProfile_isPenetrate_get(swigCPtr);
      return ret;
    } 
  }

}
