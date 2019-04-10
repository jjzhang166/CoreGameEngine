/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ASTAR_GRID : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ASTAR_GRID(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ASTAR_GRID obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ASTAR_GRID() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_ASTAR_GRID(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_VectorT_Core__ASTAR_NODE_t Nodes {
    set {
      testPINVOKE.ASTAR_GRID_Nodes_set(swigCPtr, SWIGTYPE_p_VectorT_Core__ASTAR_NODE_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.ASTAR_GRID_Nodes_get(swigCPtr);
      SWIGTYPE_p_VectorT_Core__ASTAR_NODE_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_VectorT_Core__ASTAR_NODE_t(cPtr, false);
      return ret;
    } 
  }

  public ASTAR_GRID() : this(testPINVOKE.new_ASTAR_GRID(), true) {
  }

}
