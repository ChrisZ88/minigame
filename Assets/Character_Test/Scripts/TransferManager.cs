﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlueDoorPrefab;
using RedDoorPrefab;

namespace TransferManage
{
    /// <summary>传送门类型枚举
    /// 
    /// </summary>
    public enum PortalType
    {
        Red,
        Blue
    }
    /// <summary>允许被传送的tag的枚举
    /// 
    /// </summary>
    public enum TransTag
    {
        Player,
        BlueBall,
    }
    /// <summary>角色传送状态枚举
    /// 
    /// </summary>
    public enum TransType
    {
        Ready,
        Transfering,
        Over
    }
    public class TransferManager : MonoBehaviour
    {
        /// <summary>传送门资源路径
        /// 
        /// </summary>
        public static string doorpath = "Prefabs/DoorPrefab";
        void Awake()
        {

        }
        void Update()
        {




        }
        /// <summary>
        /// 根据传入类型在场景中加载传送门
        /// </summary>
        /// <param name="type"></param>
        public static GameObject instalize(PortalType type, Vector3 transform)
        {
            Debug.Log(type + "门初始化");
            GameObject door = Instantiate(Resources.Load(doorpath + "/" + type.ToString() + "DoorPrefab"), transform, Quaternion.identity) as GameObject;
            if (type == PortalType.Blue)
            {
                BlueDoor.bdoor_placed = true;
            }
            else if (type == PortalType.Red)
            {
                RedDoor.rdoor_placed = true;
            }
            return door;
        }
    }

}