<template>
  <v-layout>
    <v-flex xs12>
      <Map />
      <ScheduleAdder />
      <Schedule />
    </v-flex>
  </v-layout>
</template>

<script>
import Map from "~/components/Map.vue";
import Schedule from "~/components/Schedule.vue";
import ScheduleAdder from "~/components/ScheduleAdder.vue";

export default {
  components: {
    Map,
    Schedule,
    ScheduleAdder
  }
};
</script>
