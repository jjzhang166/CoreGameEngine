/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class MovableTextOverlay : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MovableTextOverlay(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MovableTextOverlay obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MovableTextOverlay() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_MovableTextOverlay(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public MovableTextOverlay(string name, string caption, SWIGTYPE_p_MovableObject mov, MovableTextOverlayAttributes attrs) : this(testPINVOKE.new_MovableTextOverlay(name, caption, SWIGTYPE_p_MovableObject.getCPtr(mov), MovableTextOverlayAttributes.getCPtr(attrs)), true) {
  }

  public void SetCaption(string caption) {
    testPINVOKE.MovableTextOverlay_SetCaption(swigCPtr, caption);
  }

  public void SetUpdateFrequency(SWIGTYPE_p_f32 updateFrequency) {
    testPINVOKE.MovableTextOverlay_SetUpdateFrequency(swigCPtr, SWIGTYPE_p_f32.getCPtr(updateFrequency));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAttributes(MovableTextOverlayAttributes attrs) {
    testPINVOKE.MovableTextOverlay_SetAttributes(swigCPtr, MovableTextOverlayAttributes.getCPtr(attrs));
  }

  public SWIGTYPE_p_String GetName() {
    SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.MovableTextOverlay_GetName(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_String GetCaption() {
    SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.MovableTextOverlay_GetCaption(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_f32 GetUpdateFrequency() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.MovableTextOverlay_GetUpdateFrequency(swigCPtr), true);
    return ret;
  }

  public bool IsOnScreen() {
    bool ret = testPINVOKE.MovableTextOverlay_IsOnScreen(swigCPtr);
    return ret;
  }

  public bool IsEnabled() {
    bool ret = testPINVOKE.MovableTextOverlay_IsEnabled(swigCPtr);
    return ret;
  }

  public MovableTextOverlayAttributes getAttributes() {
    IntPtr cPtr = testPINVOKE.MovableTextOverlay_getAttributes(swigCPtr);
    MovableTextOverlayAttributes ret = (cPtr == IntPtr.Zero) ? null : new MovableTextOverlayAttributes(cPtr, false);
    return ret;
  }

  public void Enable(bool Enable) {
    testPINVOKE.MovableTextOverlay_Enable(swigCPtr, Enable);
  }

  public void Update(SWIGTYPE_p_f32 elapsedTime) {
    testPINVOKE.MovableTextOverlay_Update(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_f32 GetPixelsTop() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.MovableTextOverlay_GetPixelsTop(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_f32 GetPixelsBottom() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.MovableTextOverlay_GetPixelsBottom(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_f32 GetPixelsLeft() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.MovableTextOverlay_GetPixelsLeft(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_f32 GetPixelsRight() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.MovableTextOverlay_GetPixelsRight(swigCPtr), true);
    return ret;
  }

  public void SetPixelsTop(SWIGTYPE_p_f32 px) {
    testPINVOKE.MovableTextOverlay_SetPixelsTop(swigCPtr, SWIGTYPE_p_f32.getCPtr(px));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

}