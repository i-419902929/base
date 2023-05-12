$(function () {
    const viewer = new Cesium.Viewer("cesiumContainer", {
        animation: false,       //是否显示动画控件
        homeButton: true,       //是否显示home键
        geocoder: true,         //是否显示地名查找控件，如果设置为true，则无法查询
        baseLayerPicker: true, //是否显示图层选择控件
        timeline: false,        //是否显示时间线控件
        fullscreenButton: true, //是否全屏显示
        infoBox: true,         //是否显示点击要素之后显示的信息
        sceneModePicker: true,  //是否显示投影方式控件  三维/二维
        navigationInstructionsInitiallyVisible: false, //导航指令
        navigationHelpButton: false,     //是否显示帮助信息控件
        selectionIndicator: false, //是否显示指示器组件
    });
    window.viewer = viewer;
    window.viewer._cesiumWidget._creditContainer.style.display = "none";
    window.viewer.scene.globe.depthTestAgainstTerrain = false; //图标被遮挡
    window.viewer.scene.fxaa = false;

    window.viewer.scene.postProcessStages.fxaa.enabled = true;//去锯齿 使文字清晰
    // 设置后当相机高度达到设置的最大和最小高度时将不再放大和缩小
    window.viewer.scene.screenSpaceCameraController.minimumZoomDistance = 300; //相机的高度的最小值
    window.viewer.scene.screenSpaceCameraController.maximumZoomDistance = 12000; //相机高度的最大值

    // 关闭双击事件
    window.viewer.cesiumWidget.screenSpaceEventHandler.removeInputAction(
        Cesium.ScreenSpaceEventType.LEFT_DOUBLE_CLICK
    );
    viewer.camera.flyTo({
        destination: Cesium.Cartesian3.fromDegrees(110.220501, 24.387122, 350),
        orientation: {
            heading: Cesium.Math.toRadians(0), // 水平偏角，默认正北 0
            pitch: Cesium.Math.toRadians(-90), // 俯视角，默认-90，垂直向下
            roll: 10, // 旋转角
        },
    });


});
