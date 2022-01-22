namespace OneAPIDotNet.VPL
{

    public enum MfxStatus
    {

        /// <summary>
        /// No error.
        /// </summary>
        ErrorNone = 0,

        /// <summary>
        /// Unknown error.
        /// </summary>
        ErrorUnknown = -1,

        /// <summary>
        /// Null pointer.
        /// </summary>
        ErrorNullPointer = -2,

        /// <summary>
        /// Unsupported feature.
        /// </summary>
        ErrorUnsupported = -3,

        /// <summary>
        /// Failed to allocate memory.
        /// </summary>
        ErrorMemoryAlloc = -4,

        /// <summary>
        /// Insufficient buffer at input/output.
        /// </summary>
        ErrorNotEnoughBuffer = -5,

        /// <summary>
        /// Invalid handle.
        /// </summary>
        ErrorInvalidHandle = -6,

        /// <summary>
        /// Failed to lock the memory block.
        /// </summary>
        ErrorLockMemory = -7,

        /// <summary>
        /// Member function called before initialization.
        /// </summary>
        ErrorNotInitialized = -8,

        /// <summary>
        /// The specified object is not found.
        /// </summary>
        ErrorNotFound = -9,

        /// <summary>
        /// Expect more data at input.
        /// </summary>
        ErrorMoreData = -10,

        /// <summary>
        /// Expect more surface at output.
        /// </summary>
        ErrorMoreSurface = -11,

        /// <summary>
        /// Operation aborted.
        /// </summary>
        ErrorAborted = -12,

        /// <summary>
        /// Lose the hardware acceleration device.
        /// </summary>
        ErrorDeviceLost = -13,

        /// <summary>
        /// Incompatible video parameters.
        /// </summary>
        ErrorIncompatibleVideoParam = -14,

        /// <summary>
        /// Invalid video parameters.
        /// </summary>
        ErrorInvalidVideoParam = -15,

        /// <summary>
        /// Undefined behavior.
        /// </summary>
        ErrorUndefinedBehavior = -16,

        /// <summary>
        /// Device operation failure.
        /// </summary>
        ErrorDeviceFailed = -17,

        /// <summary>
        /// Expect more bitstream buffers at output.
        /// </summary>
        ErrorMoreBitStream = -18,

        /// <summary>
        /// Device operation failure caused by GPU hang.
        /// </summary>
        ErrorGpuHang = -21,

        /// <summary>
        /// Bigger output surface required.
        /// </summary>
        ErrorReAllocSurface = -22,

        /// <summary>
        /// Write access is already acquired and user requested another write access, or read access with MFX_MEMORY_NO_WAIT flag.
        /// </summary>
        ErrorResourceMapped = -23,

        /// <summary>
        /// Feature or function not implemented.
        /// </summary>
        ErrorNotImplemented = -24,

        /// <summary>
        /// The previous asynchronous operation is in execution.
        /// </summary>
        WarningInExecution = 1,

        /// <summary>
        /// The hardware acceleration device is busy.
        /// </summary>
        WarningDeviceBusy = 2,

        /// <summary>
        /// The video parameters are changed during decoding.
        /// </summary>
        WarningVideoParamChanged = 3,

        /// <summary>
        /// Software acceleration is used.
        /// </summary>
        WarningPartialAcceleration = 4,

        /// <summary>
        /// Incompatible video parameters.
        /// </summary>
        WarningIncompatibleVideoParam = 5,

        /// <summary>
        /// The value is saturated based on its valid range.
        /// </summary>
        WarningValueNotChanged = 6,

        /// <summary>
        /// The value is out of valid range.
        /// </summary>
        WarningOutOfRange = 7,

        /// <summary>
        /// One of requested filters has been skipped.
        /// </summary>
        WarningFilterSkipped = 10,

        /// <summary>
        /// Frame is not ready, but bitstream contains partial output.
        /// </summary>
        ErrorNonePartialOutput = 12,

        /// <summary>
        /// Task has been completed.
        /// </summary>
        TaskDone = ErrorNone,

        /// <summary>
        /// There is some more work to do.
        /// </summary>
        TaskWorking = 8,

        /// <summary>
        /// Task is waiting for resources.
        /// </summary>
        TaskBusy = 9,

        /// <summary>
        /// Return MORE_DATA but submit internal asynchronous task.
        /// </summary>
        ErrorMoreDataSubmitTask = -10000

    }

}