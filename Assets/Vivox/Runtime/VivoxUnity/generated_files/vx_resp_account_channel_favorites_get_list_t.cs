//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class vx_resp_account_channel_favorites_get_list_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vx_resp_account_channel_favorites_get_list_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(vx_resp_account_channel_favorites_get_list_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~vx_resp_account_channel_favorites_get_list_t() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VivoxCoreInstancePINVOKE.delete_vx_resp_account_channel_favorites_get_list_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public vx_resp_base_t base_ {
    set {
      VivoxCoreInstancePINVOKE.vx_resp_account_channel_favorites_get_list_t_base__set(swigCPtr, vx_resp_base_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_resp_account_channel_favorites_get_list_t_base__get(swigCPtr);
      vx_resp_base_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new vx_resp_base_t(cPtr, false);
      return ret;
    } 
  }

  public int group_count {
    set {
      VivoxCoreInstancePINVOKE.vx_resp_account_channel_favorites_get_list_t_group_count_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_resp_account_channel_favorites_get_list_t_group_count_get(swigCPtr);
      return ret;
    } 
  }

  public int favorite_count {
    set {
      VivoxCoreInstancePINVOKE.vx_resp_account_channel_favorites_get_list_t_favorite_count_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_resp_account_channel_favorites_get_list_t_favorite_count_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_vx_channel_favorite_group groups {
    set {
      VivoxCoreInstancePINVOKE.vx_resp_account_channel_favorites_get_list_t_groups_set(swigCPtr, SWIGTYPE_p_p_vx_channel_favorite_group.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_resp_account_channel_favorites_get_list_t_groups_get(swigCPtr);
      SWIGTYPE_p_p_vx_channel_favorite_group ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_vx_channel_favorite_group(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_vx_channel_favorite favorites {
    set {
      VivoxCoreInstancePINVOKE.vx_resp_account_channel_favorites_get_list_t_favorites_set(swigCPtr, SWIGTYPE_p_p_vx_channel_favorite.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_resp_account_channel_favorites_get_list_t_favorites_get(swigCPtr);
      SWIGTYPE_p_p_vx_channel_favorite ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_vx_channel_favorite(cPtr, false);
      return ret;
    } 
  }

  public vx_resp_account_channel_favorites_get_list_t() : this(VivoxCoreInstancePINVOKE.new_vx_resp_account_channel_favorites_get_list_t(), true) {
  }

}
