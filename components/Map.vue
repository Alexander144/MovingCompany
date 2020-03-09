<template>
  <GMap
    ref="gMap"
    :center="{ lat: locations[0].lat, lng: locations[0].lng }"
    :options="{ fullscreenControl: false }"
    :zoom="13"
  >
    <GMapMarker
      v-for="location in locations"
      :key="location.id"
      :position="{ lat: location.lat, lng: location.lng }"
    >
      <GMapInfoWindow>
        <code>
          lat: {{ location.lat }}, lng: {{ location.lng }}, {{ location.id }}
        </code>
      </GMapInfoWindow>
    </GMapMarker>
  </GMap>
</template>

<script>
export default {
  components: {},
  data() {
    return {
      currentLocation: {},
      locations: [
        {
          id: 1,
          lat: 59.94251,
          lng: 10.823992
        },
        {
          id: 2,
          lat: 59.937171,
          lng: 10.813011
        }
      ]
    };
  }
};
</script>

<style lang="less" scoped>
.GMap {
  height: 100%;
  /deep/ .GMap__Wrapper {
    height: 100%;
  }
}
</style>
