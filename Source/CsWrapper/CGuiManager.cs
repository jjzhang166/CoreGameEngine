/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CGuiManager : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CGuiManager(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CGuiManager obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CGuiManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_CGuiManager(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static CGuiManager Instance() {
    IntPtr cPtr = testPINVOKE.CGuiManager_Instance();
    CGuiManager ret = (cPtr == IntPtr.Zero) ? null : new CGuiManager(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Core__GUI__IGuiStrategy CreateStrategy(string Name, E_GUI_STRATEGY StrategyType) {
    IntPtr cPtr = testPINVOKE.CGuiManager_CreateStrategy__SWIG_0(swigCPtr, Name, (int)StrategyType);
    SWIGTYPE_p_Core__GUI__IGuiStrategy ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__GUI__IGuiStrategy(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Core__GUI__IGuiStrategy CreateStrategy(string Name) {
    IntPtr cPtr = testPINVOKE.CGuiManager_CreateStrategy__SWIG_1(swigCPtr, Name);
    SWIGTYPE_p_Core__GUI__IGuiStrategy ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__GUI__IGuiStrategy(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Core__GUI__IGuiStrategy GetStrategy(string Name) {
    IntPtr cPtr = testPINVOKE.CGuiManager_GetStrategy(swigCPtr, Name);
    SWIGTYPE_p_Core__GUI__IGuiStrategy ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__GUI__IGuiStrategy(cPtr, false);
    return ret;
  }

  public void DeleteStrategy(string Name) {
    testPINVOKE.CGuiManager_DeleteStrategy(swigCPtr, Name);
  }

}