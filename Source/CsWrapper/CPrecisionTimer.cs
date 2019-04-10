/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CPrecisionTimer : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CPrecisionTimer(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CPrecisionTimer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CPrecisionTimer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_CPrecisionTimer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public CPrecisionTimer() : this(testPINVOKE.new_CPrecisionTimer(), true) {
  }

  public void Start() {
    testPINVOKE.CPrecisionTimer_Start(swigCPtr);
  }

  public double Stop() {
    double ret = testPINVOKE.CPrecisionTimer_Stop(swigCPtr);
    return ret;
  }

}
