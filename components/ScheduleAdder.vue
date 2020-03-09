<template>
  <div class="text-center">
    <v-btn top absolute rounded height="50px" @click="openPopup()">
      New order
    </v-btn>
    <v-dialog v-model="isVisible" max-width="712">
      <v-card class="pa-5">
        <v-col cols="12" class="text-center">
          <v-date-picker v-model="date"> </v-date-picker>
        </v-col>
        <v-text-field label="Type:" :model="subject"></v-text-field>
        <v-text-field label="Name:" :model="subject"></v-text-field>
        <v-text-field label="Phonenumber:" :model="subject"></v-text-field>
        <v-text-field label="Mail:" :model="subject"></v-text-field>
        <v-text-field label="Note:" :model="subject"></v-text-field>
        <v-text-field label="From:" :model="subject"></v-text-field>
        <v-text-field label="To:" :model="subject"></v-text-field>
        <v-card-actions class="pa-0 justify-center">
          <v-btn rounded @click="addSchedule()">
            Save
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
  </div>
</template>

<script>
export default {
  data() {
    return {
      isVisible: false,
      date: new Date().toISOString().substr(0, 7)
    };
  },
  computed: {},
  methods: {
    addSchedule() {
      // this.$store.dispatch("mails/sendMail", {
      //   files,
      //   data: {
      //     content,
      //     subject,
      //     to: mailAdresses
      //   }
      // });
      this.closePopup();
    },
    openPopup() {
      this.isVisible = true;
    },
    closePopup() {
      this.isVisible = false;
    }
  }
};
</script>
<style lang="less" scoped></style>
