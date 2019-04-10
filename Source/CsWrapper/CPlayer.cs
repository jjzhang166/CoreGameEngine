/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CPlayer : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CPlayer(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CPlayer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CPlayer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_CPlayer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void Update(SWIGTYPE_p_f32 elapsedTime, SWIGTYPE_p_OIS__Keyboard Keyboard, SWIGTYPE_p_OIS__Mouse Mouse) {
    testPINVOKE.CPlayer_Update(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime), SWIGTYPE_p_OIS__Keyboard.getCPtr(Keyboard), SWIGTYPE_p_OIS__Mouse.getCPtr(Mouse));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_SceneNode GetPlayerNode() {
    IntPtr cPtr = testPINVOKE.CPlayer_GetPlayerNode(swigCPtr);
    SWIGTYPE_p_SceneNode ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_SceneNode(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Entity GetPlayerEntity() {
    IntPtr cPtr = testPINVOKE.CPlayer_GetPlayerEntity(swigCPtr);
    SWIGTYPE_p_Entity ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Entity(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_f32 GetHealth() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayer_GetHealth(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_f32 GetViewRange() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayer_GetViewRange(swigCPtr), true);
    return ret;
  }

  public E_PLAYER_STATE GetPlayerState() {
    E_PLAYER_STATE ret = (E_PLAYER_STATE)testPINVOKE.CPlayer_GetPlayerState(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Core__AI__CFpsVehicle GetAiVehicle() {
    IntPtr cPtr = testPINVOKE.CPlayer_GetAiVehicle(swigCPtr);
    SWIGTYPE_p_Core__AI__CFpsVehicle ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__AI__CFpsVehicle(cPtr, false);
    return ret;
  }

  public CCharacterState GetCharacterState() {
    IntPtr cPtr = testPINVOKE.CPlayer_GetCharacterState(swigCPtr);
    CCharacterState ret = (cPtr == IntPtr.Zero) ? null : new CCharacterState(cPtr, false);
    return ret;
  }

  public E_PLAYER_TEAM GetPlayerTeam() {
    E_PLAYER_TEAM ret = (E_PLAYER_TEAM)testPINVOKE.CPlayer_GetPlayerTeam(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Vector3 GetPosition() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayer_GetPosition(swigCPtr), true);
    return ret;
  }

  public string GetName() {
    string ret = testPINVOKE.CPlayer_GetName(swigCPtr);
    return ret;
  }

  public string GetMeshName() {
    string ret = testPINVOKE.CPlayer_GetMeshName(swigCPtr);
    return ret;
  }

  public bool GetIsVisible() {
    bool ret = testPINVOKE.CPlayer_GetIsVisible(swigCPtr);
    return ret;
  }

  public bool GetIsHumanPlayer() {
    bool ret = testPINVOKE.CPlayer_GetIsHumanPlayer(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Vector3 GetDirection() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayer_GetDirection(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_VectorT_Core__CInventoryItem_p_t GetItems() {
    SWIGTYPE_p_VectorT_Core__CInventoryItem_p_t ret = new SWIGTYPE_p_VectorT_Core__CInventoryItem_p_t(testPINVOKE.CPlayer_GetItems(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Vector3 GetHeadPosition() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayer_GetHeadPosition(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Quaternion GetHeadRotation() {
    SWIGTYPE_p_Quaternion ret = new SWIGTYPE_p_Quaternion(testPINVOKE.CPlayer_GetHeadRotation(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Vector3 GetBodyPosition() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayer_GetBodyPosition(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Quaternion GetBodyRotation() {
    SWIGTYPE_p_Quaternion ret = new SWIGTYPE_p_Quaternion(testPINVOKE.CPlayer_GetBodyRotation(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Core__AI__CFpsVehicle GetAiTarget() {
    IntPtr cPtr = testPINVOKE.CPlayer_GetAiTarget(swigCPtr);
    SWIGTYPE_p_Core__AI__CFpsVehicle ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__AI__CFpsVehicle(cPtr, false);
    return ret;
  }

  public void GetAiPathPoints(SWIGTYPE_p_VectorT_Vector3_t Paths) {
    testPINVOKE.CPlayer_GetAiPathPoints(swigCPtr, SWIGTYPE_p_VectorT_Vector3_t.getCPtr(Paths));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public CInventoryItem GetCurrentInventoryItem() {
    IntPtr cPtr = testPINVOKE.CPlayer_GetCurrentInventoryItem(swigCPtr);
    CInventoryItem ret = (cPtr == IntPtr.Zero) ? null : new CInventoryItem(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Vector3 GetEyePosition() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayer_GetEyePosition(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Vector3 GetCharacterControllerSize() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(testPINVOKE.CPlayer_GetCharacterControllerSize(swigCPtr), true);
    return ret;
  }

  public E_LOS_TYPE GetLoSType() {
    E_LOS_TYPE ret = (E_LOS_TYPE)testPINVOKE.CPlayer_GetLoSType(swigCPtr);
    return ret;
  }

  public bool GetIsFps() {
    bool ret = testPINVOKE.CPlayer_GetIsFps(swigCPtr);
    return ret;
  }

  public string GetPlayerType() {
    string ret = testPINVOKE.CPlayer_GetPlayerType(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Core__Physics__IPhysicsStrategy GetPhysicsStrategy() {
    IntPtr cPtr = testPINVOKE.CPlayer_GetPhysicsStrategy(swigCPtr);
    SWIGTYPE_p_Core__Physics__IPhysicsStrategy ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__Physics__IPhysicsStrategy(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Core__Physics__ICharacterController GetCharacterController() {
    IntPtr cPtr = testPINVOKE.CPlayer_GetCharacterController(swigCPtr);
    SWIGTYPE_p_Core__Physics__ICharacterController ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Core__Physics__ICharacterController(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_f32 GetRunSpeed() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayer_GetRunSpeed(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_f32 GetWalkSpeed() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayer_GetWalkSpeed(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_f32 GetSprintSpeed() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayer_GetSprintSpeed(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_f32 GetCrawlSpeed() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayer_GetCrawlSpeed(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_f32 GetDieTime() {
    SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.CPlayer_GetDieTime(swigCPtr), true);
    return ret;
  }

  public string GetMovableText() {
    string ret = testPINVOKE.CPlayer_GetMovableText(swigCPtr);
    return ret;
  }

  public void SetRunSpeed(SWIGTYPE_p_f32 Speed) {
    testPINVOKE.CPlayer_SetRunSpeed(swigCPtr, SWIGTYPE_p_f32.getCPtr(Speed));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetWalkSpeed(SWIGTYPE_p_f32 Speed) {
    testPINVOKE.CPlayer_SetWalkSpeed(swigCPtr, SWIGTYPE_p_f32.getCPtr(Speed));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSprintSpeed(SWIGTYPE_p_f32 Speed) {
    testPINVOKE.CPlayer_SetSprintSpeed(swigCPtr, SWIGTYPE_p_f32.getCPtr(Speed));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCrawlSpeed(SWIGTYPE_p_f32 Speed) {
    testPINVOKE.CPlayer_SetCrawlSpeed(swigCPtr, SWIGTYPE_p_f32.getCPtr(Speed));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDieTime(SWIGTYPE_p_f32 Time) {
    testPINVOKE.CPlayer_SetDieTime(swigCPtr, SWIGTYPE_p_f32.getCPtr(Time));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetHealth(SWIGTYPE_p_f32 Health) {
    testPINVOKE.CPlayer_SetHealth(swigCPtr, SWIGTYPE_p_f32.getCPtr(Health));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetVisible(bool Visible) {
    testPINVOKE.CPlayer_SetVisible(swigCPtr, Visible);
  }

  public void SetPlayerState(E_PLAYER_STATE State) {
    testPINVOKE.CPlayer_SetPlayerState(swigCPtr, (int)State);
  }

  public void SetAiVehicle(SWIGTYPE_p_Core__AI__CFpsVehicle Vehicle) {
    testPINVOKE.CPlayer_SetAiVehicle(swigCPtr, SWIGTYPE_p_Core__AI__CFpsVehicle.getCPtr(Vehicle));
  }

  public void SetCharacterState(E_PLAYER_STATE State) {
    testPINVOKE.CPlayer_SetCharacterState(swigCPtr, (int)State);
  }

  public void SetExactCharacterState(string State) {
    testPINVOKE.CPlayer_SetExactCharacterState(swigCPtr, State);
  }

  public void SetPlayerPosition(SWIGTYPE_p_Vector3 Position) {
    testPINVOKE.CPlayer_SetPlayerPosition__SWIG_0(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(Position));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPlayerPosition(SWIGTYPE_p_f32 x, SWIGTYPE_p_f32 y, SWIGTYPE_p_f32 z) {
    testPINVOKE.CPlayer_SetPlayerPosition__SWIG_1(swigCPtr, SWIGTYPE_p_f32.getCPtr(x), SWIGTYPE_p_f32.getCPtr(y), SWIGTYPE_p_f32.getCPtr(z));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPlayerTeam(E_PLAYER_TEAM Team) {
    testPINVOKE.CPlayer_SetPlayerTeam(swigCPtr, (int)Team);
  }

  public void SetHumanPlayer(bool isPlayer) {
    testPINVOKE.CPlayer_SetHumanPlayer(swigCPtr, isPlayer);
  }

  public void SetViewRange(SWIGTYPE_p_f32 Range) {
    testPINVOKE.CPlayer_SetViewRange(swigCPtr, SWIGTYPE_p_f32.getCPtr(Range));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTextLabelCaption(string Text) {
    testPINVOKE.CPlayer_SetTextLabelCaption(swigCPtr, Text);
  }

  public void SetTextLabelEnabled(bool Enabled) {
    testPINVOKE.CPlayer_SetTextLabelEnabled(swigCPtr, Enabled);
  }

  public void SetAiTarget(SWIGTYPE_p_Core__AI__CFpsVehicle Target) {
    testPINVOKE.CPlayer_SetAiTarget(swigCPtr, SWIGTYPE_p_Core__AI__CFpsVehicle.getCPtr(Target));
  }

  public void SetAiPathPoints(SWIGTYPE_p_VectorT_Vector3_t PathPoints) {
    testPINVOKE.CPlayer_SetAiPathPoints(swigCPtr, SWIGTYPE_p_VectorT_Vector3_t.getCPtr(PathPoints));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetName(string LabelName) {
    testPINVOKE.CPlayer_SetName(swigCPtr, LabelName);
  }

  public void SetDirection(SWIGTYPE_p_Vector3 Direction) {
    testPINVOKE.CPlayer_SetDirection(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(Direction));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetLoSType(E_LOS_TYPE Type) {
    testPINVOKE.CPlayer_SetLoSType(swigCPtr, (int)Type);
  }

  public bool CanSee(SWIGTYPE_p_Vector3 Position) {
    bool ret = testPINVOKE.CPlayer_CanSee__SWIG_0(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(Position));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CanSee(CPlayer Player) {
    bool ret = testPINVOKE.CPlayer_CanSee__SWIG_1(swigCPtr, CPlayer.getCPtr(Player));
    return ret;
  }

  public virtual CPlayer Duplicate(string PlayerType) {
    IntPtr cPtr = testPINVOKE.CPlayer_Duplicate(swigCPtr, PlayerType);
    CPlayer ret = (cPtr == IntPtr.Zero) ? null : new CPlayer(cPtr, false);
    return ret;
  }

  public void AddItem(CInventoryItem Item) {
    testPINVOKE.CPlayer_AddItem(swigCPtr, CInventoryItem.getCPtr(Item));
  }

  public void RemoveItem(CInventoryItem Item) {
    testPINVOKE.CPlayer_RemoveItem(swigCPtr, CInventoryItem.getCPtr(Item));
  }

  public void RemoveAllItems() {
    testPINVOKE.CPlayer_RemoveAllItems(swigCPtr);
  }

  public void DropAllItems() {
    testPINVOKE.CPlayer_DropAllItems(swigCPtr);
  }

  public void UseItem(CPlayer Player, CInventoryItem Item) {
    testPINVOKE.CPlayer_UseItem__SWIG_0(swigCPtr, CPlayer.getCPtr(Player), CInventoryItem.getCPtr(Item));
  }

  public void UseItem(CPlayer Player) {
    testPINVOKE.CPlayer_UseItem__SWIG_1(swigCPtr, CPlayer.getCPtr(Player));
  }

  public void UseItem(CGameObject GameObject, CInventoryItem Item) {
    testPINVOKE.CPlayer_UseItem__SWIG_2(swigCPtr, CGameObject.getCPtr(GameObject), CInventoryItem.getCPtr(Item));
  }

  public void UseItem(CGameObject GameObject) {
    testPINVOKE.CPlayer_UseItem__SWIG_3(swigCPtr, CGameObject.getCPtr(GameObject));
  }

  public void DebugLoS(bool Show) {
    testPINVOKE.CPlayer_DebugLoS(swigCPtr, Show);
  }

  public virtual void OnHit(CProjectile Projectile, SWIGTYPE_p_Vector3 Direction) {
    testPINVOKE.CPlayer_OnHit__SWIG_0(swigCPtr, CProjectile.getCPtr(Projectile), SWIGTYPE_p_Vector3.getCPtr(Direction));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnHit(CInventoryItem InventoryItem, CPlayer Owner, SWIGTYPE_p_Vector3 Direction) {
    testPINVOKE.CPlayer_OnHit__SWIG_1(swigCPtr, CInventoryItem.getCPtr(InventoryItem), CPlayer.getCPtr(Owner), SWIGTYPE_p_Vector3.getCPtr(Direction));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnShotFired() {
    testPINVOKE.CPlayer_OnShotFired(swigCPtr);
  }

  public virtual void OnMove(SWIGTYPE_p_f32 elapsedTime, SWIGTYPE_p_OIS__Keyboard Keyboard) {
    testPINVOKE.CPlayer_OnMove(swigCPtr, SWIGTYPE_p_f32.getCPtr(elapsedTime), SWIGTYPE_p_OIS__Keyboard.getCPtr(Keyboard));
    if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
  }

  public void OnPickupItem() {
    testPINVOKE.CPlayer_OnPickupItem(swigCPtr);
  }

  public virtual void OnKill(CPlayer PlayerKilled, CProjectile Projectile) {
    testPINVOKE.CPlayer_OnKill__SWIG_0(swigCPtr, CPlayer.getCPtr(PlayerKilled), CProjectile.getCPtr(Projectile));
  }

  public virtual void OnKill(CPlayer PlayerKilled, CInventoryItem InventoryItem) {
    testPINVOKE.CPlayer_OnKill__SWIG_1(swigCPtr, CPlayer.getCPtr(PlayerKilled), CInventoryItem.getCPtr(InventoryItem));
  }

}
