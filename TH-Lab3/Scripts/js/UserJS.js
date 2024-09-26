function Homnay() {
    var date = new Date();
    var month = date.getMonth() + 1;

    document.write("Hôm nay là ngày " + date.getDate()
        + " tháng " + month + " năm " + date.getFullYear());
}