//用layer弹出图层
function layerFrame(url, title, w, h, shade) {
    var layerIndex = layer.open({
        type: 2,
        title: title,
        shadeClose: shade,
        shade: 0.6,
        scrollbar: false,
        area: [setWight(w) + 'px', setHeight(h) + 'px'],
        content: url
    });
    return layerIndex;
}

//设置弹窗高度
function setHeight(h) {
    return showH > h ? h : showH;
}
//设置弹窗高度
function setWight(w) {
    return showW > w ? w : showW;
}

//用layer弹出确认窗
function layerConfirm(uniqueid, title) {
    layer.confirm(title, function() {
        __doPostBack(uniqueid, '')
    })
    return false;
}