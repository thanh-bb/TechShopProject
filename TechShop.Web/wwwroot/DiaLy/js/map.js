


//Khai báo đối tượng chính chứa bản đồ gắn vào thẻ div tên "mapObject"
var mapObject = L.map("map", { center: [10.030249, 105.772097], zoom: 18 });
//hoặc: var mapObject = L.map('map').setView([10.030249, 105.772097], 17);

//Bản đồ nền dạng Raster
L.tileLayer(
	"http://mt0.google.com/vt/lyrs=y&hl=en&x={x}&y={y}&z={z}",
	{
		attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
	}
).addTo(mapObject);
