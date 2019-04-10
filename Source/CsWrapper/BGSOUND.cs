/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BGSOUND : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BGSOUND(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BGSOUND obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BGSOUND() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_BGSOUND(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_String FileName {
    set {
      testPINVOKE.BGSOUND_FileName_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.BGSOUND_FileName_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String Name {
    set {
      testPINVOKE.BGSOUND_Name_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.BGSOUND_Name_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool Loop {
    set {
      testPINVOKE.BGSOUND_Loop_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.BGSOUND_Loop_get(swigCPtr);
      return ret;
    } 
  }

  public bool Stream {
    set {
      testPINVOKE.BGSOUND_Stream_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.BGSOUND_Stream_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 Gain {
    set {
      testPINVOKE.BGSOUND_Gain_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.BGSOUND_Gain_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public BGSOUND() : this(testPINVOKE.new_BGSOUND(), true) {
  }

}
