<template>
  <v-navigation-drawer right v-model="drawer" fixed app>
    <v-list-item>
      <v-list-item-content>
        <v-list-item-title class="title">
          Order
        </v-list-item-title>
      </v-list-item-content>
    </v-list-item>
    <ScheduleCard />
  </v-navigation-drawer>
</template>

<script>
import ScheduleCard from "./ScheduleCard";
export default {
  components: { ScheduleCard },
  data() {
    return {
      drawer: true
    };
  }
};
</script>
