<template>
  <div>
   
      <h1>Permissions Form</h1>

     <div class="row">
         <div class="col-md-3">

         </div>       
         <div class="col-md-6">
           <b/>         
            <div>
            <div class="form-group">
              <label for="Name">Employer name</label>
              <input v-model="$store.state.permission.employerName" type="text" class="form-control" id="Name" >
            </div>
            <div class="form-group">
              <label for="LastName">Employer last name</label>
              <input v-model="$store.state.permission.employerLastName" type="text" class="form-control" id="LastName" >
            </div>

           <div class="form-group">
              <label for="PermissionType">Permission Type</label>
              <select class="form-control" id="PermissionType" v-model="$store.state.permission.idPermissionType"  >
                <option v-for="item of $store.state.listPermissionType" v-bind:key="item.index" v-bind:value="item.idPermissionType" >
                    {{ item.description }}
                </option>          
              </select>
            </div>

             <div class="form-group">
              <label for="PermissionDate">Permission Date</label>
              <input v-model="$store.state.permission.permissionDate" type="date" class="form-control" id="PermissionDate" >
            </div>
                
               <button class="btn btn-primary" @click="save()" >Save</button>
             </div>
         </div>   
         <div class="col-md-3">

         </div>   
    </div>
     

  </div>
</template>

<script>

import { mapActions,mapState} from 'vuex';

export default {
  name: 'PermissionForm',
  components: {
    
  },
  computed:{
      ...mapState(['listPermissionType','permission'])
  },
  methods:{
        ...mapActions(['getAllPermissionTypes','savePermission']),
       async save(){
           if(this.$store.state.permission.employerName === "" || this.$store.state.permission.employerLastName === "" || this.$store.state.permission.idPermissionType === null || this.$store.state.permission.permissionDate === null){
             await alert('YOU HAVE TO COMPLETE ALL THE INFORMATION');
              
           } else{
             
              await this.savePermission();
              await this.$router.push('/');
           }

             
           
        
        }
  },
  async beforeMount(){
    await this.getAllPermissionTypes();
    this.$store.state.listPermissionType.unshift({ idPermissionType: null, description: "--SELECCIONAR--" });
  }
}
</script>
