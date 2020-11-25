<template>
  <div class="home">
   
      <h1>Permissions Lists</h1>

      <div class="float-right" >
        <b-button variant="success" to="/PermissionForm" >Add Permission</b-button>
         <br />
      </div>
     

      <table class="table table-striped" >
        <thead>
          <tr>
            <th>ID</th>
            <th>Employer Full Name</th>
            <th>Date</th>
            <th>Permission Type</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="item in $store.state.listPermissions" v-bind:key="item.index" >
             <td>
               {{ item.idPermission }}
             </td>
              <td>
               {{ item.employerName }} {{ item.employerLastName }}
             </td>
             <td>
               {{ item.permissionDate }}
             </td>
               <td>
               {{ item.permissionType.description }}
             </td>
             <td class="justify-content-between">       
                <b-button size="lg" variant="primary" class="mb-2">
                  <b-icon icon="pencil" @click="EditPermission()" ></b-icon>
                </b-button>

                 <b-button size="lg" variant="danger" class="mb-2">
                  <b-icon icon="trash" @click="openModal(item)" ></b-icon>
                </b-button>
             </td>
          </tr>
        </tbody>
      </table>

    <b-modal v-model="modalShow" hide-footer title="Confirmation" >
      <div class="d-block text-center">
        <h3>Are you sure you want to erase this permission?</h3>
      </div>
      <b-button class="mt-3" variant="outline-danger" block @click="erasePermissionNow()">Yes</b-button>
      <b-button class="mt-2" variant="outline-warning" block @click="modalShow = false">No</b-button>
    </b-modal>

  </div>
  


</template>

<script>
import { mapActions,mapState} from 'vuex';

export default {
  name: 'Home',
  data(){
    return{
     modalShow:false
    }
  },
  components: {
    
  },
  computed:{
      ...mapState(['permission','listPermissions'])
  },
  methods:{
        ...mapActions(['getAllPermissions','erasePermission']),
        openModal(item){
          this.$store.state.permission = item;
          this.modalShow = true;
        },
       async erasePermissionNow(){
         await this.erasePermission();
         await this.getAllPermissions();
         this.modalShow = false;
        },
        EditPermission(){
          alert('COULD NOT BE COMPLETED')
        }
  },
  async beforeMount(){
    await this.getAllPermissions();
  }
}
</script>
