"use strict";var KTGeneralAmChartsMaps=function(){var e;return{init:function(){am4core.ready((function(){am4core.useTheme(am4themes_animated),(e=am4core.create("kt_amcharts_1",am4charts.XYChart)).padding(0,15,0,15),e.dataSource.url="https://www.amcharts.com/wp-content/uploads/assets/stock/MSFT.csv",e.dataSource.parser=new am4core.CSVParser,e.dataSource.parser.options.useColumnNames=!0,e.dataSource.parser.options.reverse=!0,e.leftAxesContainer.layout="vertical";var a=e.xAxes.push(new am4charts.DateAxis);a.renderer.grid.template.location=0,a.renderer.ticks.template.length=8,a.renderer.ticks.template.strokeOpacity=.1,a.renderer.grid.template.disabled=!0,a.renderer.ticks.template.disabled=!1,a.renderer.ticks.template.strokeOpacity=.2,a.renderer.minLabelPosition=.01,a.renderer.maxLabelPosition=.99,a.keepSelection=!0,a.minHeight=30,a.groupData=!0,a.minZoomCount=5;var r=e.yAxes.push(new am4charts.ValueAxis);r.tooltip.disabled=!0,r.zIndex=1,r.renderer.baseGrid.disabled=!0,r.height=am4core.percent(65),r.renderer.gridContainer.background.fill=am4core.color("#000000"),r.renderer.gridContainer.background.fillOpacity=.05,r.renderer.inside=!0,r.renderer.labels.template.verticalCenter="bottom",r.renderer.labels.template.padding(2,2,2,2),r.renderer.fontSize="0.8em";var t=e.series.push(new am4charts.LineSeries);t.dataFields.dateX="Date",t.dataFields.valueY="Adj Close",t.tooltipText="{valueY.value}",t.name="MSFT: Value",t.defaultState.transitionDuration=0;var o=e.yAxes.push(new am4charts.ValueAxis);o.tooltip.disabled=!0,o.height=am4core.percent(35),o.zIndex=3,o.marginTop=30,o.renderer.baseGrid.disabled=!0,o.renderer.inside=!0,o.renderer.labels.template.verticalCenter="bottom",o.renderer.labels.template.padding(2,2,2,2),o.renderer.fontSize="0.8em",o.renderer.gridContainer.background.fill=am4core.color("#000000"),o.renderer.gridContainer.background.fillOpacity=.05;var i=e.series.push(new am4charts.ColumnSeries);i.dataFields.dateX="Date",i.dataFields.valueY="Volume",i.yAxis=o,i.tooltipText="{valueY.value}",i.name="MSFT: Volume",i.groupFields.valueY="sum",i.defaultState.transitionDuration=0,e.cursor=new am4charts.XYCursor;var l=new am4charts.XYChartScrollbar;l.series.push(t),l.marginBottom=20,l.scrollbarChart.xAxes.getIndex(0).minHeight=void 0,e.scrollbarX=l})),am4core.ready((function(){am4core.useTheme(am4themes_animated),(e=am4core.create("kt_amcharts_2",am4charts.XYChart)).padding(0,15,0,15),e.colors.step=3;for(var a=[],r=1e3,t=2e3,o=3e3,i=1e3,l=15;l<3e3;l++)(r+=Math.round((Math.random()<.5?1:-1)*Math.random()*100))<100&&(r=100),(t+=Math.round((Math.random()<.5?1:-1)*Math.random()*100))<100&&(t=100),(o+=Math.round((Math.random()<.5?1:-1)*Math.random()*100))<100&&(o=100),(i+=Math.round((Math.random()<.5?1:-1)*Math.random()*500))<0&&(i*=-1),a.push({date:new Date(2e3,0,l),price1:r,price2:t,price3:o,quantity:i});e.data=a,e.leftAxesContainer.layout="vertical";var n=e.xAxes.push(new am4charts.DateAxis);n.renderer.grid.template.location=0,n.renderer.ticks.template.length=8,n.renderer.ticks.template.strokeOpacity=.1,n.renderer.grid.template.disabled=!0,n.renderer.ticks.template.disabled=!1,n.renderer.ticks.template.strokeOpacity=.2,n.renderer.minLabelPosition=.01,n.renderer.maxLabelPosition=.99,n.keepSelection=!0,n.groupData=!0,n.minZoomCount=5;var d=e.yAxes.push(new am4charts.ValueAxis);d.tooltip.disabled=!0,d.zIndex=1,d.renderer.baseGrid.disabled=!0,d.height=am4core.percent(65),d.renderer.gridContainer.background.fill=am4core.color("#000000"),d.renderer.gridContainer.background.fillOpacity=.05,d.renderer.inside=!0,d.renderer.labels.template.verticalCenter="bottom",d.renderer.labels.template.padding(2,2,2,2),d.renderer.fontSize="0.8em";var s=e.series.push(new am4charts.LineSeries);s.dataFields.dateX="date",s.dataFields.valueY="price1",s.dataFields.valueYShow="changePercent",s.tooltipText="{name}: {valueY.changePercent.formatNumber('[#0c0]+#.00|[#c00]#.##|0')}%",s.name="Stock A",s.tooltip.getFillFromObject=!1,s.tooltip.getStrokeFromObject=!0,s.tooltip.background.fill=am4core.color("#fff"),s.tooltip.background.strokeWidth=2,s.tooltip.label.fill=s.stroke;var c=e.series.push(new am4charts.LineSeries);c.dataFields.dateX="date",c.dataFields.valueY="price2",c.dataFields.valueYShow="changePercent",c.tooltipText="{name}: {valueY.changePercent.formatNumber('[#0c0]+#.00|[#c00]#.##|0')}%",c.name="Stock B",c.tooltip.getFillFromObject=!1,c.tooltip.getStrokeFromObject=!0,c.tooltip.background.fill=am4core.color("#fff"),c.tooltip.background.strokeWidth=2,c.tooltip.label.fill=c.stroke;var m=e.series.push(new am4charts.LineSeries);m.dataFields.dateX="date",m.dataFields.valueY="price3",m.dataFields.valueYShow="changePercent",m.tooltipText="{name}: {valueY.changePercent.formatNumber('[#0c0]+#.00|[#c00]#.##|0')}%",m.name="Stock C",m.tooltip.getFillFromObject=!1,m.tooltip.getStrokeFromObject=!0,m.tooltip.background.fill=am4core.color("#fff"),m.tooltip.background.strokeWidth=2,m.tooltip.label.fill=m.stroke;var u=e.yAxes.push(new am4charts.ValueAxis);u.tooltip.disabled=!0,u.height=am4core.percent(35),u.zIndex=3,u.marginTop=30,u.renderer.baseGrid.disabled=!0,u.renderer.inside=!0,u.renderer.labels.template.verticalCenter="bottom",u.renderer.labels.template.padding(2,2,2,2),u.renderer.fontSize="0.8em",u.renderer.gridContainer.background.fill=am4core.color("#000000"),u.renderer.gridContainer.background.fillOpacity=.05;var p=e.series.push(new am4charts.StepLineSeries);p.fillOpacity=1,p.fill=s.stroke,p.stroke=s.stroke,p.dataFields.dateX="date",p.dataFields.valueY="quantity",p.yAxis=u,p.tooltipText="Volume: {valueY.value}",p.name="Series 2",p.groupFields.valueY="sum",p.tooltip.label.fill=p.stroke,e.cursor=new am4charts.XYCursor;var h=new am4charts.XYChartScrollbar;h.series.push(s),h.marginBottom=20,h.scrollbarChart.series.getIndex(0).dataFields.valueYShow=void 0,e.scrollbarX=h})),am4core.ready((function(){am4core.useTheme(am4themes_animated),(e=am4core.create("kt_amcharts_3",am4charts.XYChart)).data=[{year:"2011",value:6e5},{year:"2012",value:9e5},{year:"2013",value:18e4},{year:"2014",value:6e5},{year:"2015",value:35e4},{year:"2016",value:6e5},{year:"2017",value:67e4}];for(var a=0;a<e.data.length-1;a++)e.data[a].valueNext=e.data[a+1].value;var r=e.xAxes.push(new am4charts.CategoryAxis);r.dataFields.category="year",r.renderer.grid.template.location=0,r.renderer.minGridDistance=30,e.yAxes.push(new am4charts.ValueAxis).min=0;var t=e.series.push(new am4charts.ColumnSeries);t.dataFields.valueY="value",t.dataFields.categoryX="year";var o=e.series.push(new am4charts.ColumnSeries);o.dataFields.valueY="valueNext",o.dataFields.openValueY="value",o.dataFields.categoryX="year",o.columns.template.width=1,o.fill=am4core.color("#555"),o.stroke=am4core.color("#555");var i=o.bullets.push(new am4core.Triangle);i.width=10,i.height=10,i.horizontalCenter="middle",i.verticalCenter="top",i.dy=-1,i.adapter.add("rotation",(function(e,a){return n(a.dataItem)<0?180:e})),i.adapter.add("dy",(function(e,a){return n(a.dataItem)<0?1:e}));var l=o.bullets.push(new am4core.Label);function n(e){if(e){var a=e.valueY,r=e.openValueY,t=a-r;return Math.round(t/r*100)}return 0}l.padding(10,10,10,10),l.text="",l.fill=am4core.color("#0c0"),l.strokeWidth=0,l.horizontalCenter="middle",l.verticalCenter="bottom",l.fontWeight="bolder",l.adapter.add("textOutput",(function(e,a){var r=n(a.dataItem);return r?r+"%":e})),l.adapter.add("verticalCenter",(function(e,a){return n(a.dataItem)<0?"top":e})),l.adapter.add("fill",(function(e,a){return n(a.dataItem)<0?am4core.color("#c00"):e}))}))}}}();KTUtil.onDOMContentLoaded((function(){KTGeneralAmChartsMaps.init()}));
