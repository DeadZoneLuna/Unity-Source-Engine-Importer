﻿using UnityEngine;
using System.Runtime.InteropServices;

namespace Engine.Source
{
    public enum VTFImageFormat
    {
        IMAGE_FORMAT_NONE = -1,
        IMAGE_FORMAT_RGBA8888 = 0,
        IMAGE_FORMAT_ABGR8888,
        IMAGE_FORMAT_RGB888,
        IMAGE_FORMAT_BGR888,
        IMAGE_FORMAT_RGB565,
        IMAGE_FORMAT_I8,
        IMAGE_FORMAT_IA88,
        IMAGE_FORMAT_P8,
        IMAGE_FORMAT_A8,
        IMAGE_FORMAT_RGB888_BLUESCREEN,
        IMAGE_FORMAT_BGR888_BLUESCREEN,
        IMAGE_FORMAT_ARGB8888,
        IMAGE_FORMAT_BGRA8888,
        IMAGE_FORMAT_DXT1,
        IMAGE_FORMAT_DXT3,
        IMAGE_FORMAT_DXT5,
        IMAGE_FORMAT_BGRX8888,
        IMAGE_FORMAT_BGR565,
        IMAGE_FORMAT_BGRX5551,
        IMAGE_FORMAT_BGRA4444,
        IMAGE_FORMAT_DXT1_ONEBITALPHA,
        IMAGE_FORMAT_BGRA5551,
        IMAGE_FORMAT_UV88,
        IMAGE_FORMAT_UVWQ8888,
        IMAGE_FORMAT_RGBA16161616F,
        IMAGE_FORMAT_RGBA16161616,
        IMAGE_FORMAT_UVLX8888
    }

    public enum VTFImageFlags : uint
    {
        // Flags from the *.txt config file
        TEXTUREFLAGS_POINTSAMPLE = 0x00000001,
        TEXTUREFLAGS_TRILINEAR = 0x00000002,
        TEXTUREFLAGS_CLAMPS = 0x00000004,
        TEXTUREFLAGS_CLAMPT = 0x00000008,
        TEXTUREFLAGS_ANISOTROPIC = 0x00000010,
        TEXTUREFLAGS_HINT_DXT5 = 0x00000020,
        TEXTUREFLAGS_PWL_CORRECTED = 0x00000040,
        TEXTUREFLAGS_NORMAL = 0x00000080,
        TEXTUREFLAGS_NOMIP = 0x00000100,
        TEXTUREFLAGS_NOLOD = 0x00000200,
        TEXTUREFLAGS_ALL_MIPS = 0x00000400,
        TEXTUREFLAGS_PROCEDURAL = 0x00000800,

        // These are automatically generated by vtex from the texture data.
        TEXTUREFLAGS_ONEBITALPHA = 0x00001000,
        TEXTUREFLAGS_EIGHTBITALPHA = 0x00002000,

        // Newer flags from the *.txt config file
        TEXTUREFLAGS_ENVMAP = 0x00004000,
        TEXTUREFLAGS_RENDERTARGET = 0x00008000,
        TEXTUREFLAGS_DEPTHRENDERTARGET = 0x00010000,
        TEXTUREFLAGS_NODEBUGOVERRIDE = 0x00020000,
        TEXTUREFLAGS_SINGLECOPY = 0x00040000,
        TEXTUREFLAGS_PRE_SRGB = 0x00080000,

        TEXTUREFLAGS_UNUSED_00100000 = 0x00100000,
        TEXTUREFLAGS_UNUSED_00200000 = 0x00200000,
        TEXTUREFLAGS_UNUSED_00400000 = 0x00400000,

        TEXTUREFLAGS_NODEPTHBUFFER = 0x00800000,

        TEXTUREFLAGS_UNUSED_01000000 = 0x01000000,

        TEXTUREFLAGS_CLAMPU = 0x02000000,
        TEXTUREFLAGS_VERTEXTEXTURE = 0x04000000,
        TEXTUREFLAGS_SSBUMP = 0x08000000,

        TEXTUREFLAGS_UNUSED_10000000 = 0x10000000,

        TEXTUREFLAGS_BORDER = 0x20000000,

        TEXTUREFLAGS_UNUSED_40000000 = 0x40000000,
        TEXTUREFLAGS_UNUSED_80000000 = 0x80000000
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class VtfSpec
    {
        public struct tagVTFHEADER
        {
            public int Signature;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public uint[] Version;

            public uint HeaderSize;

            public ushort Width;
            public ushort Height;
            public VTFImageFlags Flags;

            public ushort Frames;
            public ushort FirstFrame;

            public int Padding0;
            public Vector3 Reflectivity;
            public int Padding1;

            public float BumpmapScale;

            public VTFImageFormat HighResImageFormat;
            public byte MipmapCount;

            public VTFImageFormat LowResImageFormat;
            public byte LowResImageWidth;
            public byte LowResImageHeight;
        }
    }
}
