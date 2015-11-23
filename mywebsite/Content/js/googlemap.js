﻿(function ($) {
    "use strict";
    $(document).ready(function () {
        $('#wrapper').easytabs({
            animate: true,
            updateHash: false,
            transitionIn: 'fadeIn',
            transitionOut: 'fadeOut',
            animationSpeed: 100,
            tabActiveClass: 'active',
            tabs: ' #main-nav.tabbed > ul > li ',
            transitionInEasing: 'linear',
            transitionOutEasing: 'linear'
        });

        $('#wrapper').bind('easytabs:after', function () {
            var styles = [
                            {
                                stylers: [
                                    { saturation: -100 }
                                ]
                            }, {
                                featureType: 'road',
                                elementType: 'geometry',
                                stylers: [
                                    { hue: "#74b7b0" },
                                    { visibility: 'simplified' }
                                ]
                            }, {
                                featureType: 'road',
                                elementType: 'labels',
                                stylers: [
                                    { visibility: 'on' }
                                ]
                            }
            ],
                           lat = -33.867487,
                           lng = 151.20699,

                          customMap = new google.maps.StyledMapType(styles,
                              { name: 'Styled Map' }),

                          mapOptions = {
                              zoom: 14,
                              scrollwheel: false,
                              disableDefaultUI: true,
                              center: new google.maps.LatLng(lat, lng),
                              mapTypeControlOptions: {
                                  mapTypeIds: [google.maps.MapTypeId.ROADMAP]
                              }
                          },
                          map = new google.maps.Map(document.getElementById('map'), mapOptions),
                          myLatlng = new google.maps.LatLng(lat, lng),

                          marker = new google.maps.Marker({
                              position: myLatlng,
                              map: map,
                              icon: {
                                  url: '/Content/img/marker.png',
                                  scaledSize: new google.maps.Size(26, 42)
                              }
                          });

            map.mapTypes.set('map_style', customMap);
            map.setMapTypeId('map_style');
        });
    });
})(jQuery);