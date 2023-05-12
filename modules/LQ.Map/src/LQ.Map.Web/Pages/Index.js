$(function () {
    const viewer = new Cesium.Viewer("cesiumContainer", {
        animation: false,       //�Ƿ���ʾ�����ؼ�
        homeButton: true,       //�Ƿ���ʾhome��
        geocoder: true,         //�Ƿ���ʾ�������ҿؼ����������Ϊtrue�����޷���ѯ
        baseLayerPicker: true, //�Ƿ���ʾͼ��ѡ��ؼ�
        timeline: false,        //�Ƿ���ʾʱ���߿ؼ�
        fullscreenButton: true, //�Ƿ�ȫ����ʾ
        infoBox: true,         //�Ƿ���ʾ���Ҫ��֮����ʾ����Ϣ
        sceneModePicker: true,  //�Ƿ���ʾͶӰ��ʽ�ؼ�  ��ά/��ά
        navigationInstructionsInitiallyVisible: false, //����ָ��
        navigationHelpButton: false,     //�Ƿ���ʾ������Ϣ�ؼ�
        selectionIndicator: false, //�Ƿ���ʾָʾ�����
    });
    window.viewer = viewer;
    window.viewer._cesiumWidget._creditContainer.style.display = "none";
    window.viewer.scene.globe.depthTestAgainstTerrain = false; //ͼ�걻�ڵ�
    window.viewer.scene.fxaa = false;

    window.viewer.scene.postProcessStages.fxaa.enabled = true;//ȥ��� ʹ��������
    // ���ú�����߶ȴﵽ���õ�������С�߶�ʱ�����ٷŴ����С
    window.viewer.scene.screenSpaceCameraController.minimumZoomDistance = 300; //����ĸ߶ȵ���Сֵ
    window.viewer.scene.screenSpaceCameraController.maximumZoomDistance = 12000; //����߶ȵ����ֵ

    // �ر�˫���¼�
    window.viewer.cesiumWidget.screenSpaceEventHandler.removeInputAction(
        Cesium.ScreenSpaceEventType.LEFT_DOUBLE_CLICK
    );
    viewer.camera.flyTo({
        destination: Cesium.Cartesian3.fromDegrees(110.220501, 24.387122, 350),
        orientation: {
            heading: Cesium.Math.toRadians(0), // ˮƽƫ�ǣ�Ĭ������ 0
            pitch: Cesium.Math.toRadians(-90), // ���ӽǣ�Ĭ��-90����ֱ����
            roll: 10, // ��ת��
        },
    });


});
